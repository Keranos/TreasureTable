using System;
using System.Collections.Generic;

namespace OSE_Treasure.Items
{
    public sealed class GemItem : TreasureTableItem
    {
        public GemItem(RollType dice, double percentage)
        {
            Dice = dice;
            Percentage = percentage;
        }

        public string Roll()
        {
            var n = RandomUtils.RollDice(Dice);

            var value = 0;
            var count = 0;
            for (int i = 0; i < n; i++)
            {
                if (RandomUtils.PercentageDice() < Percentage)
                {
                    count++;
                    var gemTableRoll = RandomUtils.RollDice(RollType.d20);
                    var idx = GemTable.FindIndex(x => x.Item1 >= gemTableRoll);
                    value += GemTable[idx].Item2;
                }
            }

            return count == 0 ? string.Empty : $"{count} gems worth {value} gold\n";
        }

        public RollType Dice { get; set; }
        public double Percentage { get; set; }

        private static readonly List<Tuple<int, int>> GemTable = new List<Tuple<int, int>>
        { new Tuple<int, int>(4, 10),
          new Tuple<int, int>(9, 50),
          new Tuple<int, int>(15, 100),
          new Tuple<int, int>(19, 500),
          new Tuple<int, int>(20, 1000)};
    }
}

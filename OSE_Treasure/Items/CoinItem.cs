using System;

namespace OSE_Treasure.Items
{
    public sealed class CoinItem : TreasureTableItem
    {
        public CoinItem(CoinType coinType, RollType dice, int value, double percentage)
        {
            CoinType = coinType;
            Dice = dice;
            Value = value;
            Percentage = percentage;
        }

        public string Roll()
        {
            if (RandomUtils.PercentageDice() > Percentage)
                return String.Empty;

            var amount = Value * RandomUtils.RollDice(Dice);

            return $"{amount} {CoinType}\n";
        }

        public CoinType CoinType { get; set; }
        public RollType Dice { get; set; }
        public int Value { get; set; }
        public double Percentage { get; set; }
    }
}

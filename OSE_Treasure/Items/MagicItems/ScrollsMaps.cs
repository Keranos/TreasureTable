using System;
using System.Collections.Generic;
using System.Text;

namespace OSE_Treasure.Items.MagicItems
{
    public sealed class ScrollMaps
    {
        public static string Roll()
        {
            var sb = new StringBuilder();
            var loot = string.Empty;
            var roll = RandomUtils.RollDice(RollType.d100);
            if (roll <= 35)
            {
                var idx = Scrolls.FindIndex(x => x.Item1 >= roll);
                for (int i = 0; i < Scrolls[idx].Item2; i++)
                    sb.Append(Spells.Roll());
            }
            else
            {
                var idx = ScrollsMapsTable.FindIndex(x => x.Item1 >= roll);
                sb.Append($"{ScrollsMapsTable[idx].Item2}\n");
            }

            return sb.ToString();
        }

        private static readonly List<Tuple<int, int>> Scrolls = new List<Tuple<int, int>>
        {
            new Tuple<int, int>(15, 1),
            new Tuple<int, int>(25, 2),
            new Tuple<int, int>(31, 3),
            new Tuple<int, int>(34, 5),
            new Tuple<int, int>(35, 7)
        };

        private static readonly List<Tuple<int, string>> ScrollsMapsTable = new List<Tuple<int, string>>
        { 
            //new Tuple<int, string>(15, "1 Spells"),
            //new Tuple<int, string>(25, "2 Spells"),
            //new Tuple<int, string>(31, "3 Spells"),
            //new Tuple<int, string>(34, "5 Spells"),
            //new Tuple<int, string>(35, "7 Spells"),
            new Tuple<int, string>(40, "Cursed Scroll"),
            new Tuple<int, string>(50, "Scroll of Protection from Elementals"),
            new Tuple<int, string>(60, "Scroll of Protection from Lycanthropes"),
            new Tuple<int, string>(65, "Scroll of Protection from Magic"),
            new Tuple<int, string>(75, "Scroll of Protection from Undead"),
            new Tuple<int, string>(78, "Treasure Map: I"),
            new Tuple<int, string>(80, "Treasure Map: II"),
            new Tuple<int, string>(82, "Treasure Map: III"),
            new Tuple<int, string>(83, "Treasure Map: IV"),
            new Tuple<int, string>(84, "Treasure Map: V"),
            new Tuple<int, string>(85, "Treasure Map: VI"),
            new Tuple<int, string>(86, "Treasure Map: VII"),
            new Tuple<int, string>(90, "Treasure Map: VIII"),
            new Tuple<int, string>(95, "Treasure Map: IX"),
            new Tuple<int, string>(96, "Treasure Map: X"),
            new Tuple<int, string>(98, "Treasure Map: XI"),
            new Tuple<int, string>(100, "Treasure Map: XII")
        };
    }
}
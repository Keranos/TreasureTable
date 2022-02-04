using System;
using System.Collections.Generic;

namespace OSE_Treasure.Items.MagicItems
{
    public sealed class Swords
    {
        public static string Roll()
        {
            var roll = RandomUtils.RollDice(RollType.d100);
            var idx = SwordsTable.FindIndex(x => x.Item1 >= roll);
            return $"{SwordsTable[idx].Item2}\n";
        }

        private static readonly List<Tuple<int, string>> SwordsTable = new List<Tuple<int, string>>
        { 
            new Tuple<int, string>(3, "Short Sword +2, Quickness"),
            new Tuple<int, string>(6, "Sword -1, Berserker (Cursed)"),
            new Tuple<int, string>(9, "Sword -1, Cursed"),
            new Tuple<int, string>(12, "Sword -2, Cursed"),
            new Tuple<int, string>(28, "Sword +1"),
            new Tuple<int, string>(31, "Sword +1, +2 vs Lyncanthropes"),
            new Tuple<int, string>(34, "Sword +1, +2 vs Spell Users"),
            new Tuple<int, string>(37, "Sword +1, +3 vs Dragons"),
            new Tuple<int, string>(40, "Sword +1, +3 vs Enchanted Creatures"),
            new Tuple<int, string>(43, "Sword +1, +3 vs Regenerating Creatures"),
            new Tuple<int, string>(46, "Sword +1, +3 vs Reptiles"),
            new Tuple<int, string>(49, "Sword +1, +3 vs Shape Changers"),
            new Tuple<int, string>(52, "Sword +1, +3 vs Undead"),
            new Tuple<int, string>(55, "Sword +1, Dragon Slayer"),
            new Tuple<int, string>(56, "Sword +1, Energy Drain"),
            new Tuple<int, string>(59, "Sword +1, Flaming"),
            new Tuple<int, string>(61, "Sword +1, Frost Brand"),
            new Tuple<int, string>(64, "Sword +1, Giant Slayer"),
            new Tuple<int, string>(69, "Sword +1, Light"),
            new Tuple<int, string>(71, "Sword +1, Locate Objects"),
            new Tuple<int, string>(72, "Sword +1, Luck Blade"),
            new Tuple<int, string>(73, "Sword +1, Sharpness"),
            new Tuple<int, string>(78, "Sword +1, Sun Blade"),
            new Tuple<int, string>(79, "Sword +1, Wishes"),
            new Tuple<int, string>(80, "Sword +1, Wounding"),
            new Tuple<int, string>(85, "Sword +2"),
            new Tuple<int, string>(87, "Sword +2, Charm Person"),
            new Tuple<int, string>(88, "Sword +2, Dancing"),
            new Tuple<int, string>(89, "Sword +2, Nines Lives Stealer"),
            new Tuple<int, string>(94, "Sword +2, Venger"),
            new Tuple<int, string>(95, "Sword +2, Vorpal"),
            new Tuple<int, string>(98, "Sword +3"),
            new Tuple<int, string>(99, "Sword +3, Defender"),
            new Tuple<int, string>(100, "Sword +3, Holy Avenger")
        };
    }
}
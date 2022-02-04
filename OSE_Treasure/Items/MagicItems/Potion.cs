using System;
using System.Collections.Generic;

namespace OSE_Treasure.Items.MagicItems
{
    public sealed class Potions
    {
        public static string Roll()
        {
            var roll = RandomUtils.RollDice(RollType.d100);
            var idx = PotionsTable.FindIndex(x => x.Item1 >= roll);
            return $"Potion of {PotionsTable[idx].Item2}\n";
        }

        private static readonly List<Tuple<int, string>> PotionsTable = new List<Tuple<int, string>>
        {
            new Tuple<int, string>(3, "Clairaudience"),
            new Tuple<int, string>(7, "Clairvoyance"),
            new Tuple<int, string>(10, "Control Animal"),
            new Tuple<int, string>(13, "Control Dragon"),
            new Tuple<int, string>(16, "Control Giant"),
            new Tuple<int, string>(19, "Control Human"),
            new Tuple<int, string>(22, "Control Plant"),
            new Tuple<int, string>(25, "Control Undead"),
            new Tuple<int, string>(32, "Delusion"),
            new Tuple<int, string>(35, "Diminution"),
            new Tuple<int, string>(39, "ESP"),
            new Tuple<int, string>(43, "Fire Resistance"),
            new Tuple<int, string>(47, "Flying"),
            new Tuple<int, string>(51, "Gaseous Form"),
            new Tuple<int, string>(55, "Giant Strength"),
            new Tuple<int, string>(59, "Growth"),
            new Tuple<int, string>(63, "Healing"),
            new Tuple<int, string>(68, "Heroism"),
            new Tuple<int, string>(72, "Invisibility"),
            new Tuple<int, string>(76, "Invulnerability"),
            new Tuple<int, string>(80, "Levitation"),
            new Tuple<int, string>(84, "Longevity"),
            new Tuple<int, string>(86, "Poison"),
            new Tuple<int, string>(89, "Polymorph Self"),
            new Tuple<int, string>(97, "Speed"),
            new Tuple<int, string>(100, "Treasure Finding"),
        };
    }
}
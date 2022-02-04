using System;
using System.Collections.Generic;

namespace OSE_Treasure.Items.MagicItems
{
    public sealed class Rings
    {
        public static string Roll()
        {
            var roll = RandomUtils.RollDice(RollType.d100);
            var idx = RingsTable.FindIndex(x => x.Item1 >= roll);
            return $"Ring of {RingsTable[idx].Item2}\n";
        }

        private static readonly List<Tuple<int, string>> RingsTable = new List<Tuple<int, string>>
        {   
            new Tuple<int, string>(5, "Control Animals"),
            new Tuple<int, string>(10, "Control Humanss"),
            new Tuple<int, string>(16, "Control Plants"),
            new Tuple<int, string>(26, "Delusion"),
            new Tuple<int, string>(29, "Djinni Summoning"),
            new Tuple<int, string>(39, "Fire Resistance"),
            new Tuple<int, string>(50, "Invisibility"),
            new Tuple<int, string>(55, "Protection +1, 5' radius"),
            new Tuple<int, string>(70, "Protection +1"),
            new Tuple<int, string>(72, "Regeneration"),
            new Tuple<int, string>(74, "Spell Storing"),
            new Tuple<int, string>(80, "Spell Turning"),
            new Tuple<int, string>(82, "Telekinesis"),
            new Tuple<int, string>(88, "Water Walking"),
            new Tuple<int, string>(94, "Weakness"),
            new Tuple<int, string>(96, "Wishes, 1-2"),
            new Tuple<int, string>(97, "Wishes, 1-3"),
            new Tuple<int, string>(98, "Wishes, 1-4"),
            new Tuple<int, string>(100, "X-Ray Vision"),
        };
    }
}
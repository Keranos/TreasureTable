using System;
using System.Collections.Generic;

namespace OSE_Treasure.Items.MagicItems
{
    public sealed class RodsStavesWands
    {
        public static string Roll()
        {
            var roll = RandomUtils.RollDice(RollType.d100);

            var charges = roll <= 2 ? 0 :
                roll <= 17 ? RandomUtils.RollDice(RollType.d10) :
                roll <= 44 ? RandomUtils.RollDice(RollType.d10x3) :
                RandomUtils.RollDice(RollType.d10x2);

            var idx = RodsStavesWandsTable.FindIndex(x => x.Item1 >= roll);
            return RodsStavesWandsTable[idx].Item2 + (roll <= 2 ? "\n" : $", {charges} charges\n");
        }

        private static readonly List<Tuple<int, string>> RodsStavesWandsTable = new List<Tuple<int, string>>
        {
            new Tuple<int, string>(2, "Immovable Rod"),
            new Tuple<int, string>(5, "Rod of Absoption"),
            new Tuple<int, string>(11, "Rod of Cancellation"),
            new Tuple<int, string>(12, "Rod of Captivation"),
            new Tuple<int, string>(14, "Rod of Lordly Might"),
            new Tuple<int, string>(15, "Rod of Parrying"),
            new Tuple<int, string>(16, "Rod of Resurrection"),
            new Tuple<int, string>(17, "Rod of Striking"),
            new Tuple<int, string>(18, "Staff of Commanding"),
            new Tuple<int, string>(20, "Staff of Dispelling"),
            new Tuple<int, string>(26, "Staff of Healing"),
            new Tuple<int, string>(27, "Staff of Power"),
            new Tuple<int, string>(30, "Staff of Snakes"),
            new Tuple<int, string>(33, "Staff of Striking"),
            new Tuple<int, string>(36, "Staff of Swarming Insects"),
            new Tuple<int, string>(38, "Staff of the Healer"),
            new Tuple<int, string>(40, "Staff of Withering"),
            new Tuple<int, string>(41, "Staff of Wizardry"),
            new Tuple<int, string>(44, "Staff of the Woodlands"),
            new Tuple<int, string>(47, "Wand of Cold"),
            new Tuple<int, string>(51, "Wand of Enemy Detection"),
            new Tuple<int, string>(54, "Wand of Fear"),
            new Tuple<int, string>(57, "Wand of Fireballs"),
            new Tuple<int, string>(61, "Wand of Illusion"),
            new Tuple<int, string>(64, "Wand of Lightning Bolts"),
            new Tuple<int, string>(69, "Wand of Magic Detection"),
            new Tuple<int, string>(74, "Wand of Magic Missiles"),
            new Tuple<int, string>(79, "Wand of Metal Detection"),
            new Tuple<int, string>(84, "Wand of Negation"),
            new Tuple<int, string>(87, "Wand of Paralysation"),
            new Tuple<int, string>(90, "Wand of Polymorph"),
            new Tuple<int, string>(94, "Wand of Radiance"),
            new Tuple<int, string>(97, "Wand of Secret Door Detection"),
            new Tuple<int, string>(98, "Wand of Summoning"),
            new Tuple<int, string>(100, "Wand of Trap Detection")
        };
    }
}
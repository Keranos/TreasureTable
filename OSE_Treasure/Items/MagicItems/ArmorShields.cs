using System;
using System.Collections.Generic;

namespace OSE_Treasure.Items.MagicItems
{
    public sealed class ArmorShields
    {
        public static string Roll()
        {
            var roll = RandomUtils.RollDice(RollType.d100);
            var idx = ArmorShieldTable.FindIndex(x => x.Item1 >= roll);

            var result = ArmorShieldTable[idx].Item2;
            var rollArmor = RandomUtils.RollDice(RollType.d8);
            var armorType = !result.Contains("Armour") ? string.Empty
                : rollArmor < 3 ? "Leather "
                : rollArmor < 7 ? "Chainmail "
                : "Plate ";

            return $"{armorType}{result}\n";
        }

        private static readonly List<Tuple<int, string>> ArmorShieldTable = new List<Tuple<int, string>>
        {
            new Tuple<int, string>(15, "Armour +1"),
            new Tuple<int, string>(25, "Armour +1, Shield +1"),
            new Tuple<int, string>(27, "Armour +1, Shield +2"),
            new Tuple<int, string>(28, "Armour +1, Shield +3"),
            new Tuple<int, string>(33, "Armour +2"),
            new Tuple<int, string>(36, "Armour +2, Shield +1"),
            new Tuple<int, string>(41, "Armour +2, Shield +2"),
            new Tuple<int, string>(42, "Armour +2, Shield +3"),
            new Tuple<int, string>(45, "Armour +3"),
            new Tuple<int, string>(46, "Armour +3, Shield +1"),
            new Tuple<int, string>(47, "Armour +3, Shield +2"),
            new Tuple<int, string>(48, "Armour +3, Shield +3"),
            new Tuple<int, string>(51, "Cursed Armour -1"),
            new Tuple<int, string>(53, "Cursed Armour -2"),
            new Tuple<int, string>(54, "Cursed Armour -2, Shield +1"),
            new Tuple<int, string>(56, "Cursed Armour AC9"),
            new Tuple<int, string>(62, "Cursed Shield -2"),
            new Tuple<int, string>(65, "Cursed Shield AC9"),
            new Tuple<int, string>(85, "Shield +1"),
            new Tuple<int, string>(95, "Shield +2"),
            new Tuple<int, string>(100, "Shield +3"),
        };
    }
}

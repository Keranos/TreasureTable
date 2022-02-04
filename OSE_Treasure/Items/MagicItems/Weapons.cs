using System;
using System.Collections.Generic;

namespace OSE_Treasure.Items.MagicItems
{
    public sealed class Weapons
    {
        public static string Roll()
        {
            var roll = RandomUtils.RollDice(RollType.d100);
            var idx = WeaponsTable.FindIndex(x => x.Item1 >= roll);
            return $"{WeaponsTable[idx].Item2}\n";
        }

        private static readonly List<Tuple<int, string>> WeaponsTable = new List<Tuple<int, string>>
        { 
            new Tuple<int, string>(1, "Arrow +1, Slaying"),
            new Tuple<int, string>(10, "Arrows +1 (2d6)"),
            new Tuple<int, string>(12, "Arrows +1 (3d10)"),
            new Tuple<int, string>(15, "Arrows +2 (1d6)"),
            new Tuple<int, string>(19, "Axe +1"),
            new Tuple<int, string>(21, "Axe +2"),
            new Tuple<int, string>(24, "Bow +1"),
            new Tuple<int, string>(25, "Crossbow +1, Distance"),
            new Tuple<int, string>(26, "Crossbow +1, Speed"),
            new Tuple<int, string>(27, "Crossbow +2, Accuracy"),
            new Tuple<int, string>(29, "Crossbow Bolts +1 (2d6)"),
            new Tuple<int, string>(31, "Crossbow Bolts +1 (3d10)"),
            new Tuple<int, string>(36, "Crossbow Bolts +2 (1d6)"),
            new Tuple<int, string>(39, "Dagger +1"),
            new Tuple<int, string>(40, "Dagger +1, Buckle"),
            new Tuple<int, string>(41, "Dagger +1, Throwing"),
            new Tuple<int, string>(42, "Dagger +1, Venomous"),
            new Tuple<int, string>(45, "Dagger +2, +3 vs orcs, goblins, and kobolds"),
            new Tuple<int, string>(46, "Dagger +2, Biter"),
            new Tuple<int, string>(50, "Javelin of Lighting (1d4+1)"),
            new Tuple<int, string>(54, "Javelin of Seeking (2d4)"),
            new Tuple<int, string>(58, "Mace +1"),
            new Tuple<int, string>(59, "Mace +1, Disrupting"),
            new Tuple<int, string>(62, "Mace +2"),
            new Tuple<int, string>(63, "Mace +3"),
            new Tuple<int, string>(68, "Sling +1"),
            new Tuple<int, string>(69, "Sling +1 Impact"),
            new Tuple<int, string>(71, "Spear -1, Backbiter"),
            new Tuple<int, string>(75, "Spear +1"),
            new Tuple<int, string>(77, "Spear +2"),
            new Tuple<int, string>(78, "Spear +3"),
            new Tuple<int, string>(80, "Staff +1, Growing"),
            new Tuple<int, string>(82, "Trident -2, Yearning"),
            new Tuple<int, string>(87, "Trident +1, Fish Command"),
            new Tuple<int, string>(89, "Trident +1, Submission"),
            new Tuple<int, string>(93, "Trident +2, Warning"),
            new Tuple<int, string>(96, "War Hammer +1"),
            new Tuple<int, string>(98, "War Hammer +2"),
            new Tuple<int, string>(99, "War Hammer +3, Dwarven Thrower"),
            new Tuple<int, string>(100, "War Hammer +3, Thunderbolts"),
        };
    }
}
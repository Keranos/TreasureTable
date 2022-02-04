using System;
using System.Collections.Generic;
using System.Text;

namespace OSE_Treasure.Items
{
    public sealed class MagicItem : TreasureTableItem
    {
        public MagicItem(MagicItemType[] magicItemType, double percentage)
        {
            MagicTypes = magicItemType;
            Percentage = percentage;
        }

        public MagicItem(MagicItemType[] magicItemType, double percentage, RollType rollType)
        {
            MagicTypes = magicItemType;
            Percentage = percentage;
            RollType = rollType;
        }

        public string Roll()
        {
            if (RandomUtils.PercentageDice() > Percentage)
                return string.Empty;

            var sb = new StringBuilder();
            var n = RollType == RollType.none ? 1 : RandomUtils.RollDice(RollType);

            for (int i = 0; i < n; i++)
                foreach (var t in MagicTypes)
                    sb.Append(SearchTable(t));

            return sb.ToString();
        }

        private string SearchTable(MagicItemType mit)
        {
            switch (mit)
            {
                case MagicItemType.All:
                    var magicTypeRoll = RandomUtils.RollDice(RollType.d100);
                    var idx = MagicTypeRollTable.FindIndex(x => x.Item1 >= magicTypeRoll);
                    return SearchTable(MagicTypeRollTable[idx].Item2);
                case MagicItemType.Armour:
                    return MagicItems.ArmorShields.Roll();
                case MagicItemType.Misc:
                    return MagicItems.Misc.Roll();
                case MagicItemType.Potion:
                    return MagicItems.Potions.Roll();
                case MagicItemType.Ring:
                    return MagicItems.Rings.Roll();
                case MagicItemType.Rod:
                    return MagicItems.RodsStavesWands.Roll();
                case MagicItemType.ScrollMap:
                    return MagicItems.ScrollMaps.Roll();
                case MagicItemType.Sword:
                    return MagicItems.Swords.Roll();
                case MagicItemType.Weapon:
                    return MagicItems.Weapons.Roll();
                case MagicItemType.SwordArmourWeapon:
                    var percentage = RandomUtils.PercentageDice();
                    return percentage < 0.33 ? MagicItems.ArmorShields.Roll()
                        : percentage < 0.66 ? MagicItems.Swords.Roll()
                        : MagicItems.Weapons.Roll();
                case MagicItemType.NoWeapon:
                    var p2 = RandomUtils.PercentageDice();
                    return p2 < 0.2 ? MagicItems.ArmorShields.Roll()
                        : p2 < 0.4 ? MagicItems.Misc.Roll()
                        : p2 < 0.6 ? MagicItems.Potions.Roll()
                        : p2 < 0.8 ? MagicItems.RodsStavesWands.Roll()
                        : MagicItems.ScrollMaps.Roll();
                default:
                    return string.Empty;
            }
        }

        public MagicItemType[] MagicTypes { get; set; }
        public double Percentage { get; set; }
        public RollType RollType = RollType.none;

        private static readonly List<Tuple<int, MagicItemType>> MagicTypeRollTable = new List<Tuple<int, MagicItemType>>
        { new Tuple<int, MagicItemType>(10, MagicItemType.Armour),
          new Tuple<int, MagicItemType>(15, MagicItemType.Misc),
          new Tuple<int, MagicItemType>(35, MagicItemType.Potion),
          new Tuple<int, MagicItemType>(40, MagicItemType.Ring),
          new Tuple<int, MagicItemType>(45, MagicItemType.Rod),
          new Tuple<int, MagicItemType>(75, MagicItemType.ScrollMap),
          new Tuple<int, MagicItemType>(95, MagicItemType.Sword),
          new Tuple<int, MagicItemType>(100, MagicItemType.Weapon) };
    }
}

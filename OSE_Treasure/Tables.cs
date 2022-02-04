using OSE_Treasure.Items;
using System.Collections.Generic;

namespace OSE_Treasure
{
    public class Tables
    {
        public static readonly Dictionary<string, List<TreasureTableItem>> ParentTreasureTable =
            new Dictionary<string, List<TreasureTableItem>>
                {
                { "A", new List<TreasureTableItem>{ new CoinItem(CoinType.Cooper, RollType.d6, 1000, 0.25),
                                                    new CoinItem(CoinType.Silver, RollType.d6, 1000, 0.30),
                                                    new CoinItem(CoinType.Electrum, RollType.d4, 1000, 0.20),
                                                    new CoinItem(CoinType.Gold, RollType.d6x2, 1000, 0.35),
                                                    new CoinItem(CoinType.Platinum, RollType.d2, 1000, 0.25),
                                                    new GemItem(RollType.d6x6, 0.5),
                                                    new JewelleryItem(RollType.d6x3, 0.5),
                                                    new MagicItem(new [] {MagicItemType.All, MagicItemType.All, MagicItemType.All}, 0.3)} },

                { "B", new List<TreasureTableItem>{ new CoinItem(CoinType.Cooper, RollType.d8, 1000, 0.5),
                                                    new CoinItem(CoinType.Silver, RollType.d6, 1000, 0.25),
                                                    new CoinItem(CoinType.Electrum, RollType.d4, 1000, 0.25),
                                                    new CoinItem(CoinType.Gold, RollType.d3, 1000, 0.25),
                                                    new GemItem(RollType.d6, 0.25),
                                                    new JewelleryItem(RollType.d6, 0.25),
                                                    new MagicItem(new [] {MagicItemType.SwordArmourWeapon}, 0.1)} },

                { "C", new List<TreasureTableItem>{ new CoinItem(CoinType.Cooper, RollType.d12, 1000, 0.2),
                                                    new CoinItem(CoinType.Silver, RollType.d4, 1000, 0.3),
                                                    new CoinItem(CoinType.Electrum, RollType.d4, 1000, 0.1),
                                                    new GemItem(RollType.d4, 0.25),
                                                    new JewelleryItem(RollType.d4, 0.25),
                                                    new MagicItem(new [] {MagicItemType.All, MagicItemType.All}, 0.1) } },

                { "D", new List<TreasureTableItem>{ new CoinItem(CoinType.Cooper, RollType.d8, 1000, 0.1),
                                                    new CoinItem(CoinType.Silver, RollType.d12, 1000, 0.15),
                                                    new CoinItem(CoinType.Gold, RollType.d6, 1000, 0.6),
                                                    new GemItem(RollType.d8, 0.3),
                                                    new JewelleryItem(RollType.d8, 0.3),
                                                    new MagicItem(new [] {MagicItemType.All, MagicItemType.All, MagicItemType.Potion}, 0.15) } },

                { "E", new List<TreasureTableItem>{ new CoinItem(CoinType.Cooper, RollType.d10, 1000, 0.05),
                                                    new CoinItem(CoinType.Silver, RollType.d12, 1000, 0.3),
                                                    new CoinItem(CoinType.Electrum, RollType.d4, 1000, 0.25),
                                                    new CoinItem(CoinType.Gold, RollType.d8, 1000, 0.25),
                                                    new GemItem(RollType.d10, 0.1),
                                                    new JewelleryItem(RollType.d10, 0.1),
                                                    new MagicItem(new [] {MagicItemType.All, MagicItemType.All, MagicItemType.All, MagicItemType.ScrollMap}, 0.25) } },

                { "F", new List<TreasureTableItem>{ new CoinItem(CoinType.Silver, RollType.d10x2, 1000, 0.1),
                                                    new CoinItem(CoinType.Electrum, RollType.d8, 1000, 0.2),
                                                    new CoinItem(CoinType.Gold, RollType.d12, 1000, 0.45),
                                                    new CoinItem(CoinType.Platinum, RollType.d3, 1000, 0.3),
                                                    new GemItem(RollType.d12x2, 0.2),
                                                    new JewelleryItem(RollType.d12, 0.1),
                                                    new MagicItem(new [] {MagicItemType.NoWeapon, MagicItemType.NoWeapon, MagicItemType.NoWeapon, MagicItemType.ScrollMap, MagicItemType.Potion }, 0.3) } },

                { "G", new List<TreasureTableItem>{ new CoinItem(CoinType.Gold, RollType.d4, 10000, 0.5),
                                                    new CoinItem(CoinType.Platinum, RollType.d6, 1000, 0.5),
                                                    new GemItem(RollType.d6x3, 0.25),
                                                    new JewelleryItem(RollType.d10, 0.25),
                                                    new MagicItem(new [] {MagicItemType.All, MagicItemType.All, MagicItemType.All, MagicItemType.All, MagicItemType.ScrollMap }, 0.35) } },

                { "H", new List<TreasureTableItem>{ new CoinItem(CoinType.Cooper, RollType.d8x3, 1000, 0.25),
                                                    new CoinItem(CoinType.Silver, RollType.d100, 1000, 0.5),
                                                    new CoinItem(CoinType.Electrum, RollType.d4, 10000, 0.5),
                                                    new CoinItem(CoinType.Gold, RollType.d6, 10000, 0.5),
                                                    new CoinItem(CoinType.Platinum, RollType.d4x5, 1000, 0.25),
                                                    new GemItem(RollType.d100, 0.5),
                                                    new JewelleryItem(RollType.d4, 0.5, 10),
                                                    new MagicItem(new [] {MagicItemType.All, MagicItemType.All, MagicItemType.All, MagicItemType.All, MagicItemType.ScrollMap, MagicItemType.Potion }, 0.3) } },

                { "I", new List<TreasureTableItem>{ new CoinItem(CoinType.Platinum, RollType.d8, 1000, 0.3),
                                                    new GemItem(RollType.d6x2, 0.5),
                                                    new JewelleryItem(RollType.d6x2, 0.5),
                                                    new MagicItem(new [] {MagicItemType.All }, 0.15)} },

                { "J", new List<TreasureTableItem>{ new CoinItem(CoinType.Cooper, RollType.d4, 1000, 0.25),
                                                    new CoinItem(CoinType.Silver, RollType.d3, 1000, 0.1)} },

                { "K", new List<TreasureTableItem>{ new CoinItem(CoinType.Silver, RollType.d6, 1000, 0.3),
                                                    new CoinItem(CoinType.Electrum, RollType.d2, 1000, 0.1)} },

                { "L", new List<TreasureTableItem>{ new GemItem(RollType.d4, 0.5)} },

                { "M", new List<TreasureTableItem>{ new CoinItem(CoinType.Gold, RollType.d4x2, 1000, 0.4),
                                                    new CoinItem(CoinType.Platinum, RollType.d6x5, 1000, 0.5),
                                                    new GemItem(RollType.d4x5, 0.55),
                                                    new JewelleryItem(RollType.d6x2, 0.45)} },

                { "N", new List<TreasureTableItem>{ new MagicItem(new [] {MagicItemType.Potion}, 0.4, RollType.d4x2)} },

                { "O", new List<TreasureTableItem>{ new MagicItem(new[] {MagicItemType.ScrollMap}, 0.5, RollType.d4)} },

                { "P", new List<TreasureTableItem>{ new CoinItem(CoinType.Cooper, RollType.d8x3, 1, 1.0)} },

                { "Q", new List<TreasureTableItem>{ new CoinItem(CoinType.Silver, RollType.d6x3, 1, 1.0)} },

                { "R", new List<TreasureTableItem>{ new CoinItem(CoinType.Electrum, RollType.d6x2, 1, 1.0)} },

                { "S", new List<TreasureTableItem>{ new CoinItem(CoinType.Gold, RollType.d4x2, 1, 1.0)} },

                { "T", new List<TreasureTableItem>{ new CoinItem(CoinType.Platinum, RollType.d6, 1, 1.0)} },

                { "U", new List<TreasureTableItem>{ new CoinItem(CoinType.Cooper, RollType.d100, 1, 0.1),
                                                    new CoinItem(CoinType.Silver, RollType.d100, 1, 0.1),
                                                    new CoinItem(CoinType.Gold, RollType.d100, 1, 0.05),
                                                    new GemItem(RollType.d4, 0.05),
                                                    new JewelleryItem(RollType.d4, 0.05),
                                                    new MagicItem(new [] {MagicItemType.All}, 0.02)} },

                { "V", new List<TreasureTableItem>{ new CoinItem(CoinType.Cooper, RollType.d100, 1, 0.1),
                                                    new CoinItem(CoinType.Electrum, RollType.d100, 1, 0.05),
                                                    new CoinItem(CoinType.Gold, RollType.d100, 1, 0.1),
                                                    new CoinItem(CoinType.Platinum, RollType.d100, 1, 0.05),
                                                    new GemItem(RollType.d4, 0.1),
                                                    new JewelleryItem(RollType.d4, 0.1),
                                                    new MagicItem(new [] {MagicItemType.All}, 0.05)} }
            };
    }
}

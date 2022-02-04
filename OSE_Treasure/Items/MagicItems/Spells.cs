using System;
using System.Collections.Generic;
using System.Linq;

namespace OSE_Treasure.Items.MagicItems
{
    public sealed class Spells
    {
        public static string Roll()
        {
            var kind = RandomUtils.PercentageDice();
            var level = RandomUtils.RollDice(RollType.d100);
            var type = RandomUtils.RollDice(RollType.d2);

            if (kind <= 0.25)
            {
                if (type == 1)
                {
                    if (level <= 25)
                        return $"Cleric 1: {GetRandomSpell(Cleric1)}\n";
                    else if (level <= 50)
                        return $"Cleric 2: {GetRandomSpell(Cleric2)}\n";
                    else if (level <= 70)
                        return $"Cleric 3: {GetRandomSpell(Cleric3)}\n";
                    else if (level <= 85)
                        return $"Cleric 4: {GetRandomSpell(Cleric4)}\n";
                    else
                        return $"Cleric 5: {GetRandomSpell(Cleric5)}\n";
                }
                else
                {
                    if (level <= 25)
                        return $"Druid 1: {GetRandomSpell(Druid1)}\n";
                    else if (level <= 50)
                        return $"Druid 2: {GetRandomSpell(Druid2)}\n";
                    else if (level <= 70)
                        return $"Druid 3: {GetRandomSpell(Druid3)}\n";
                    else if (level <= 85)
                        return $"Druid 4: {GetRandomSpell(Druid4)}\n";
                    else
                        return $"Druid 5: {GetRandomSpell(Druid5)}\n";
                }
            }
            else 
            {
                if (type == 1)
                {
                    if (level <= 25)
                        return $"Illusionist 1: {GetRandomSpell(Illusionist1)}\n";
                    else if (level <= 50)
                        return $"Illusionist 2: {GetRandomSpell(Illusionist2)}\n";
                    else if (level <= 70)
                        return $"Illusionist 3: {GetRandomSpell(Illusionist3)}\n";
                    else if (level <= 85)
                        return $"Illusionist 4: {GetRandomSpell(Illusionist4)}\n";
                    else if (level <= 95)
                        return $"Illusionist 5: {GetRandomSpell(Illusionist5)}\n";
                    else
                        return $"Illusionist 6: {GetRandomSpell(Illusionist6)}\n";
                }
                else
                {
                    if (level <= 25)
                        return $"Mage 1: {GetRandomSpell(Mage1)}\n";
                    else if (level <= 50)
                        return $"Mage 2: {GetRandomSpell(Mage2)}\n";
                    else if (level <= 70)
                        return $"Mage 3: {GetRandomSpell(Mage3)}\n";
                    else if (level <= 85)
                        return $"Mage 4: {GetRandomSpell(Mage4)}\n";
                    else if (level <= 95)
                        return $"Mage 5: {GetRandomSpell(Mage5)}\n";
                    else
                        return $"Mage 6: {GetRandomSpell(Mage6)}\n";
                }
            }
        }

        private static string GetRandomSpell(List<string> spells)
        {
            var idx = RandomUtils.rand.Next(spells.Count);
            return spells[idx];
        }

        // Cleric Spells
        private static readonly List<string> Cleric1 = new List<string>
        {
            "Cure Light Wounds",
            "Detect Evil",
            "Detect Magic",
            "Light",
            "Protection from Evil",
            "Purify Food and Water",
            "Remove Fear",
            "Resist Cold"
        };

        private static readonly List<string> Cleric2 = new List<string>
        {
            "Bless",
            "Find Traps",
            "Hold Person",
            "Know Alignment",
            "Resist Fire",
            "Silence 15' Radius",
            "Snake Charm",
            "Speak With Animals",
        };

        private static readonly List<string> Cleric3 = new List<string>
        { 
            "Continual Light",
            "Cure Disease",
            "Growth of Animal",
            "Locate Object",
            "Remove Curse",
            "Striking"
        };

        private static readonly List<string> Cleric4 = new List<string>
        {
            "Create Water",
            "Cure Serious Wounds",
            "Neutralize Poison",
            "Protection from Evil 10' Radius",
            "Speak with Plants",
            "Sticks to Snakes"
        };

        private static readonly List<string> Cleric5 = new List<string>
        {
            "Commune",
            "Create Food",
            "Dispel Evil",
            "Insect Plague",
            "Quest",
            "Raise Dead"
        };

        // Druid Spells
        private static readonly List<string> Druid1 = new List<string>
        {
            "Animal Friendship",
            "Detect Danger",
            "Entangle",
            "Faerie Fire",
            "Invisibility to Animals",
            "Locate Plant or Animal",
            "Predict Weather",
            "Speak with Animals"
        };

        private static readonly List<string> Druid2 = new List<string>
        {
            "Barkskin",
            "Create Water",
            "Cure Light Wounds",
            "Heat Metal",
            "Obscuring Mist",
            "Produce Flame",
            "Slow Poison",
            "Warp Wood"
        };

        private static readonly List<string> Druid3 = new List<string>
        {
            "Call Lighting",
            "Growth of Nature",
            "Hold Animal",
            "Protection from Poison",
            "Tree Shape",
            "Water Breathing"
        };

        private static readonly List<string> Druid4 = new List<string>
        {
            "Cure Serious Wounds",
            "Dispel Magic",
            "Protection from Fire and Lightning",
            "Speak with Plants",
            "Summon Animals",
            "Temperature Control"
        };

        private static readonly List<string> Druid5 = new List<string>
        {
            "Commune with Nature",
            "Control Weather",
            "Pass Plant",
            "Protection from Plants and Animals",
            "Transmute Rock to Mud",
            "Wall of Thorns"
        };

        // Illusionist Spells
        private static readonly List<string> Illusionist1 = new List<string>
        {
            "Auditory Illusion",
            "Chromatic Orb",
            "Colour Spray",
            "Dancing Lights",
            "Detect Illusion",
            "Glamour",
            "Hypnotism",
            "Light",
            "Phantasmal Force",
            "Read Magic",
            "Spook",
            "Wall of Fog"
        };

        private static readonly List<string> Illusionist2 = new List<string>
        {
            "Blindness/Deafness",
            "Blur",
            "Detect Magic",
            "False Aura",
            "Fascinate",
            "Hypnotic Pattern",
            "Improved Phantasmal Force",
            "Invisibility",
            "Magic Mouth",
            "Mirror Image",
            "Quasimorph",
            "Whispering Wind"
        };

        private static readonly List<string> Illusionist3 = new List<string>
        {
            "Blacklight",
            "Dispel Illusion",
            "Fear",
            "Hallucinatory Terrain",
            "Invisibility 10' Radius",
            "Nondetection",
            "Paralysation",
            "Phantom Seed",
            "Rope Trick",
            "Spectral Force",
            "Suggestion",
            "Wraithform"
        };

        private static readonly List<string> Illusionist4 = new List<string>
        {
            "Confusion",
            "Detect Magic",
            "Emotion",
            "Illusory Stamina",
            "Improced Invisibility",
            "Massmorph",
            "Minor Creation",
            "Phantasmal Killer",
            "Rainbow Pattern",
            "Shadow Monsters",
            "Solid Fog",
            "Veil of Abandonment"
        };

        private static readonly List<string> Illusionist5 = new List<string>
        {
            "Chaos",
            "Demi-Shadow Monsters",
            "Illusion",
            "Looking Glass",
            "Major Creation", 
            "Maze of Mirrors",
            "Projected Image",
            "Seeming",
            "Shadowcast",
            "Shadowy Transformation",
            "Time Flow",
            "Visitation"
        };

        private static readonly List<string> Illusionist6 = new List<string>
        {
            "Acid Fog",
            "Dream Quest",
            "Impersonation",
            "Manifest Dream",
            "Mass Suggestion",
            "Mislead",
            "Permanent Illusion",
            "Shades",
            "Through the Looking Glass",
            "Triggered Illusion",
            "True Seeing",
            "Vision"
        };

        // Mage spells
        private static readonly List<string> Mage1 = new List<string>
        {
            "Charm Person",
            "Detect Magic",
            "Floating Disc",
            "Hold Portal",
            "Light",
            "Magic Missile",
            "Protection from Evil",
            "Read Languages",
            "Read Magic",
            "Shield",
            "Sleep",
            "Ventroquilism"
        };

        private static readonly List<string> Mage2 = new List<string>
        {
            "Continual Light",
            "Detect Evil",
            "Detect Invisible",
            "ESP",
            "Invisibility",
            "Knock",
            "Levitate",
            "Locate Object",
            "Mirror Image",
            "Phantasmal Force",
            "Web",
            "Wizard Lock"
        };

        private static readonly List<string> Mage3 = new List<string>
        {
            "Clairvoyance",
            "Dispel Magic",
            "Fire Ball",
            "Fly",
            "Haste",
            "Hold Person",
            "Infravision",
            "Invisibility 10' Radius",
            "Lightning Bolt",
            "Protection from Evil 10' Radius",
            "Protection from Normal Missiles",
            "Water Breathing"
        };

        private static readonly List<string> Mage4 = new List<string>
        {
            "Charm Monster",
            "Confustion",
            "Dimension Door",
            "Growth of Plants",
            "Hallucinatory Terrain",
            "Massmorph",
            "Polymorph Others",
            "Polymorph Self",
            "Remove Curse",
            "Wall of Fire",
            "Wall of Ice",
            "Wizard Eye"
        };

        private static readonly List<string> Mage5 = new List<string>
        {
            "Animate Dead",
            "Cloudkill",
            "Conjure Elemental",
            "Contact Higher Plans",
            "Feeblemind",
            "Hold Monster",
            "Magic Jar",
            "Pass-Wall",
            "Telekinesis",
            "Teleport",
            "Transmute Rock to Mud",
            "Wall of Stone"
        };

        private static readonly List<string> Mage6 = new List<string>
        {
            "Anti-Magic Shell",
            "Control Weather",
            "Death Spell",
            "Disintegrate",
            "Geas",
            "Invisible Stalker",
            "Lower Water",
            "Move Earth",
            "Part Water",
            "Projected Image",
            "Reincarnation",
            "Stone to Flesh"
        };
    }
}

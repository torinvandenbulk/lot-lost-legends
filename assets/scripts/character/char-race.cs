using UnityEngine

public enum Race
{
    Dragonborn,
    Goliath,
    Human,
    Halfling,
    Gnome,
    Dwarf,
    Elf,
    Half-Elf,
    Half-Orc,
    Tiefling,
    Triton,
    Aarakocra,
    Genasi,
    Yuan-ti Pureblood,
    Firbolg,
    Changeling,
    Vedalken,
    Goblin,
    Orc,
    Bugbear,
    Hobgoblin,
    Kobold,
    Lizardfolk,
    Tortle,
    Minotaur,
    Drow,
    Eladrin,
    Shadar-kai,
    Mountain Dwarf,
    Hill Dwarf,
    Duergar Dwarf,
    Wood Elf,
    High Elf,
    Drow Elf,
    Eladrin Elf,
    Half-Elf,
    Sun Elf,
    Moon Elf,
    Sea Elf,
    Wood Half-Elf,
    High Half-Elf,
    Drow Half-Elf,
    Eladrin Half-Elf,
    Half-Orc,
    Aasimar,
    Tiefling,
    Triton,

    // Official D&D 5e statistic bonuses

    Dragonborn: Strength +2, Charisma +1
    Goliath: Strength +2, Constitution +2
    Human: +1 to all ability scores
    Halfling: Dexterity +2, +1 to any other ability score
    Gnome: Intelligence +2, +1 to any other ability score
    Dwarf: Constitution +2, +2 to Wisdom or Constitution
    Elf: Dexterity +2, +1 to Intelligence or Wisdom
    Half-Elf: +2 to two different ability scores
    Half-Orc: Strength +2, Constitution +1
    Tiefling: Charisma +2, +1 to Intelligence or Dexterity
    Triton: Strength +1, Constitution +1, +1 to Wisdom or Charisma
    
     public static void UpdateStats(Character character, Race race)
     {
        character.Strength += race.StrengthBonus;
        character.Dexterity += race.DexterityBonus;
        character.Constitution += race.ConstitutionBonus;
        character.Intelligence += race.IntelligenceBonus;
        character.Wisdom += race.WisdomBonus;
        character.Charisma += race.CharismaBonus;
     }
}

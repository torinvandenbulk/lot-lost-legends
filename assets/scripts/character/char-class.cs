using UnityEngine;

public enum CharacterClass
{
    Cleric,
    Paladin,
    Fighter,
    Sorcerer,
    Barbarian,
    Rogue
}

public class CharacterClassData : MonoBehaviour
{
    public CharacterClass characterClass;

    public CharacterClassData(CharacterClass characterClass)
    {
        this.characterClass = characterClass;
    }

    public string GetCharacterClassAsString()
    {
        switch (characterClass)
        {
            case CharacterClass.Cleric:
                return "Cleric";
            case CharacterClass.Paladin:
                return "Paladin";
            case CharacterClass.Fighter:
                return "Fighter";
            case CharacterClass.Sorcerer:
                return "Sorcerer";
            case CharacterClass.Barbarian:
                return "Barbarian";
            case CharacterClass.Rogue:
                return "Rogue";
            default:
                return null;
        }
    }

    public void ApplyBonuses()
    {
        switch (characterClass)
        {
            case CharacterClass.Cleric:
                Strength += 1;
                Wisdom += 2;
                break;
            case CharacterClass.Paladin:
                Strength += 2;
                Charisma += 2;
                break;
            case CharacterClass.Fighter:
                Strength += 2;
                Constitution += 1;
                break;
            case CharacterClass.Sorcerer:
                Charisma += 2;
                Intelligence += 1;
                break;
            case CharacterClass.Barbarian:
                Strength += 3;
                Constitution += 2;
                break;
            case CharacterClass.Rogue:
                Dexterity += 2;
                Intelligence += 1;
                break;
        }
    }
}

using UnityEngine;

public enum CharacterClass
{
    Cleric,
    Paladin,
    Fighter,
    Sorcerer,
    Druid,
    Barbarian,
    Rogue
}

[System.Serializable]
public class HeroAttributes
{
    public int strength;
    public int dexterity;
    public int constitution;
    public int intelligence;
    public int wisdom;
    public int charisma;
}

public class CharacterClassData : MonoBehaviour
{
    public CharacterClass characterClass;
    public HeroAttributes attributes;
}

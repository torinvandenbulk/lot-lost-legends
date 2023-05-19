using UnityEngine;

public class HeroSelection : MonoBehaviour
{
    public Dictionary<string, Character> characters = new Dictionary<string, Character>
    {
        { "Mal the Marbled Man", new Character()
        {
            characterName = "Mal the Marbled Man",
            level = 1,
            CharacterAttributes = new CharacterAttributes()
            {
                Strength = 18,
                Dexterity = 16,
                Constitution = 14,
                Intelligence = 12,
                Wisdom = 10,
                Charisma = 8
            },
            race = Race.Dragonborn,
            class = CharacterClass.Paladin
        } },
        { "Kairus", new Character()
        {
            characterName = "Kairus",
            level = 1,
            CharacterAttributes = new CharacterAttributes()
            {
                Strength = 16,
                Dexterity = 18,
                Constitution = 14,
                Intelligence = 12,
                Wisdom = 10,
                Charisma = 8
            },
            race = Race.Goliath,
            class = CharacterClass.Barbarian
        } },
        { "Josu", new Character()
        {
            characterName = "Josu",
            level = 1,
            CharacterAttributes = new CharacterAttributes()
            {
                Strength = 14,
                Dexterity = 16,
                Constitution = 18,
                Intelligence = 12,
                Wisdom = 10,
                Charisma = 8
            },
            race = Race.Genasi,
            class = CharacterClass.Monk
        } },
        { "Talyen", new Character()
        {
            characterName = "Talyen",
            level = 1,
            CharacterAttributes = new CharacterAttributes()
            {
                Strength = 12,
                Dexterity = 14,
                Constitution = 16,
                Intelligence = 12,
                Wisdom = 10,
                Charisma = 8
            },
            race = Race.Human,
            class = CharacterClass.Paladin
        } },
        { "Losk the Wanderer", new Character()
        {
            characterName = "Losk the Wanderer",
            level = 1,
            CharacterAttributes = new CharacterAttributes()
            {
                Strength = 8,
                Dexterity = 12,
                Constitution = 14,
                Intelligence = 12,
                Wisdom = 10,
                Charisma = 8
            },
            race = Race.Earth Genasi,
            class = CharacterClass.Cleric
        } }
    };

    public void Start()
    {
        // Print a list of all the available characters.
        foreach (var character in characters)
        {
            Debug.Log(character.Key + " - " + character.Value.Race + " " + character.Value.Class);
        }
    }

    public void SelectCharacter()
    {
        // Prompt the user to select a character.
        Debug.Log("Select a character:");
        string selectedCharacter = Console.ReadLine();

        // Check if the user entered a valid character name.
        if (!characters.ContainsKey(selectedCharacter))
        {
            Debug.LogError("Invalid character name.");
            return;
        }

        // Set the character's name and attributes.
        characterName = selectedCharacter;
        CharacterAttributes = GetCharacterAttributes(selectedCharacter);
        race = GetRace(characterName);
        characterClass = GetCharacterClass(characterName);
    }

    private Character GetCharacter(string characterName)
    {
        return characters[characterName];
    }

    private CharacterAttributes GetCharacterAttributes(string characterName)
    {
        return GetCharacter(characterName).CharacterAttributes;
    }

    private Race GetRace(string characterName)
    {
        return GetCharacter(characterName).Race;
    }

    private CharacterClass GetCharacterClass(string characterName)
    {
        return GetCharacter(characterName).CharacterClass;
    }
}

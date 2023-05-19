using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    public int level;

    public CharacterAttributes CharacterAttributes;

    public int initiative;

    private void Start()
    {
        RollInitiative();
    }

    public void RollInitiative()
    {
        if (characterName == null || !encounterActive)
        {
            Debug.Log("You cannot roll initiative until you have selected a character and have come across an encounter.");
            return;
        }

        initiative = Random.Range(1, 21) + Mathf.FloorToInt((CharacterAttributes.Dexterity - 10) / 2);
    }

    public void SelectCharacter()
    {
        // Create a list of all the available characters.
        List<string> characters = new List<string> { "Mal the Marbled Man", "Kairus", "Josu", "Talyen", "Losk the Wanderer" };

        // Prompt the user to select a character.
        string selectedCharacter = PromptUserForCharacter(characters);

        // Set the character's name and attributes.
        characterName = selectedCharacter;
        CharacterAttributes = GetCharacterAttributes(selectedCharacter);
    }

    private string PromptUserForCharacter(List<string> characters)
    {
        // Print a list of all the available characters.
        foreach (string character in characters)
        {
            Debug.Log(character);
        }

        // Prompt the user to select a character.
        Debug.Log("Select a character:");
        string selectedCharacter = Console.ReadLine();

        // Check if the user entered a valid character name.
        if (!characters.Contains(selectedCharacter))
        {
            Debug.LogError("Invalid character name.");
            return null;
        }

        return selectedCharacter;
    }

    private CharacterAttributes GetCharacterAttributes(string characterName)
    {
        // Create a dictionary of character names to attributes.
        Dictionary<string, CharacterAttributes> characterAttributes = new Dictionary<string, CharacterAttributes>();

        // Add the character's attributes to the dictionary.
        characterAttributes["Mal the Marbled Man"] = new CharacterAttributes()
        {
            Strength = 18,
            Dexterity = 16,
            Constitution = 14,
            Intelligence = 12,
            Wisdom = 10,
            Charisma = 8
        };

        characterAttributes["Kairus"] = new CharacterAttributes()
        {
            Strength = 16,
            Dexterity = 18,
            Constitution = 14,
            Intelligence = 12,
            Wisdom = 10,
            Charisma = 8
        };

        characterAttributes["Josu"] = new CharacterAttributes()
        {
            Strength = 14,
            Dexterity = 16,
            Constitution = 18,
            Intelligence = 12,
            Wisdom = 10,
            Charisma = 8
        };

        characterAttributes["Talyen"] = new CharacterAttributes()
        {
            Strength = 12,
            Dexterity = 14,
            Constitution = 16,
            Intelligence = 12,
            Wisdom = 10,
            Charisma = 8
        };

        characterAttributes["Losk the Wanderer"] = new CharacterAttributes()
        {
            Strength = 8,
            Dexterity = 12,
            Constitution = 14,
            Intelligence = 12,
            Wisdom = 10,
            Charisma = 8
        };
        
        characterAttributes["Professor Henry Endsworth"] = new CharacterAttributes()
        {
            Strength = 10,
            Dexterity = 10,
            Constitution = 14,
            Intelligence = 18,
            Wisdom = 12,
            Charisma = 10
        };

        // Get the character's attributes from the dictionary.
        return characterAttributes[characterName];
    }

    public bool encounterActive = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            encounterActive = true;
        }
    }
}

public class CharacterAttributes : ScriptableObject
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
}

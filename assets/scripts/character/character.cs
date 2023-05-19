using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    public int level;

    public CharacterAttributes CharacterAttributes;

    public int initiative;
    
    public CharacterClass characterClass;

    public Race race;
    
    private void Start()
    {
        SelectCharacter();
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
        // Call the SelectCharacter() function from the char-selection.cs file.
        var charSelection = new CharSelection();
        charSelection.SelectCharacter();

        // Set the character's name and attributes.
        characterName = charSelection.characterName;
        CharacterAttributes = charSelection.CharacterAttributes;
        race = charSelection.race;
        characterClass = charSelection.characterClass;
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

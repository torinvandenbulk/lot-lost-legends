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
        var heroSelection = new HeroSelection();
        heroSelection.SelectCharacter();

        // Set the character's name and attributes.
        characterName = heroSelection.characterName;
        CharacterAttributes = heroSelection.CharacterAttributes;
        race = heroSelection.race;
        characterClass = heroSelection.characterClass;
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

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject characterPrefab;
    public Transform characterSelectionParent;
    public Text characterStatsText;

    private List<Character> characters;

    private void Start()
    {
        characters = new List<Character>();

        foreach (CharacterClass characterClass in System.Enum.GetValues(typeof(CharacterClass)))
        {
            GameObject characterObj = Instantiate(characterPrefab, characterSelectionParent);
            Character character = characterObj.GetComponent<Character>();
            CharacterClassData characterClassData = characterObj.GetComponent<CharacterClassData>();
            characterClassData.characterClass = characterClass;

            // Assign attributes based on the class
            switch (characterClass)
            {
                case CharacterClass.Cleric:
                    character.characterName = "Healer";
                    characterClassData.attributes.wisdom = 15;
                    characterClassData.attributes.charisma = 12;
                    break;
                case CharacterClass.Paladin:
                    character.characterName = "Paladin";
                    characterClassData.attributes.strength = 15;
                    characterClassData.attributes.constitution = 12;
                    break;
                case CharacterClass.Fighter:
                    character.characterName = "Fighter";
                    characterClassData.attributes.strength = 14;
                    characterClassData.attributes.constitution = 13;
                    break;
                case CharacterClass.Sorcerer:
                    character.characterName = "Sorcerer";
                    characterClassData.attributes.intelligence = 15;
                    characterClassData.attributes.charisma = 12;
                    break;
                case CharacterClass.Barbarian:
                    character.characterName = "Barbarian";
                    characterClassData.attributes.strength = 16;
                    characterClassData.attributes.constitution = 14;
                    break;
                case CharacterClass.Rogue:
                    character.characterName = "Rogue";
                    characterClassData.attributes.dexterity = 15;
                    characterClassData.attributes.charisma = 12;
                    break;
            }

            characterObj.GetComponent<Button>().onClick.AddListener(() => ShowCharacterStats(character));
            characters.Add(character);
        }
    }

    public void ShowCharacterStats(Character character)
    {
        CharacterClassData characterClassData = character.GetComponent<CharacterClassData>();
        characterStatsText.text = $"Name: {character.characterName}\nClass: {characterClassData.characterClass}\n\nStrength: {characterClassData.attributes.strength}\nDexterity: {characterClassData.attributes.dexterity}\nConstitution: {characterClassData.attributes.constitution}\nIntelligence: {characterClassData.attributes.intelligence}\nWisdom: {characterClassData.attributes.wisdom}\nCharisma: {characterClassData.attributes.charisma}";
    }
}

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
        initiative = Random.Range(1, 21) + Mathf.FloorToInt((CharacterAttributes.Dexterity - 10) / 2);
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

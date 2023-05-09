using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    public int level;

    public int strength;
    public int dexterity;
    public int constitution;
    public int intelligence;
    public int wisdom;
    public int charisma;

    public int initiative;

    private void Start()
    {
        RollInitiative();
    }

    public void RollInitiative()
    {
        initiative = Random.Range(1, 21) + Mathf.FloorToInt((dexterity - 10) / 2);
    }
}

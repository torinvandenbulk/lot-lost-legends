using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public List<Character> charactersInCombat;

    private void Start()
    {
        StartCombat();
    }

    public void StartCombat()
    {
        foreach (Character character in charactersInCombat)
        {
            character.RollInitiative();
        }

        charactersInCombat.Sort((c1, c2) => c2.initiative.CompareTo(c1.initiative));
        StartCoroutine(ExecuteTurns());
    }

    private IEnumerator ExecuteTurns()
    {
        while (true)
        {
            foreach (Character character in charactersInCombat)
            {
                // Execute character's turn
                Debug.Log($"{character.characterName} takes their turn.");

                // Placeholder for the actual turn execution
                yield return new WaitForSeconds(1);
            }
        }
    }
}

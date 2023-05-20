using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace CombatManager
{
    public class CombatManager
    {
        public static void StartCombat(Encounter encounter, DungeonPath path)
        {
            // Get the list of NPCs for the encounter
            var npcs = encounter.NPCs;

            // Roll initiative for each NPC
            foreach (var npc in npcs)
            {
                npc.Initiative = Random.Next(20);
            }

            // Sort the NPCs by initiative
            npcs.Sort((a, b) => a.Initiative - b.Initiative);

            // Print the encounter details
            Console.WriteLine("Encounter:");
            Console.WriteLine("Biome: " + encounter.Biome);
            Console.WriteLine("Number of NPCs: " + npcs.Count);
            Console.WriteLine("Challenge Rating: " + encounter.CR);

            // Print the details of each NPC
            foreach (var npc in npcs)
            {
                Console.WriteLine(npc);
            }

            // Start the combat loop
            RunCombat(npcs, path);
        }

        private static void RunCombat(List<NPC> npcs, DungeonPath path)
        {
            // Loop until all NPCs are dead or the players are dead
            while (npcs.Any(npc => npc.IsAlive) && path.IsAlive)
            {
                // Get the next NPC to act
                var npc = npcs.FirstOrDefault(npc => npc.Initiative == 0);

                // If there is no next NPC, then the players have a turn
                if (npc == null)
                {
                    // Have the players take their turn
                    path.TakeTurn();
                }
                else
                {
                    // Have the NPC take their turn
                    npc.TakeTurn(path);
                }

                // Decrement the initiative of all NPCs
                foreach (var npc in npcs)
                {
                    npc.Initiative--;
                }
            }

            // Check if the players are dead
            if (!path.IsAlive)
            {
                // The players have lost
                Console.WriteLine("The players have lost!");
            }
            else
            {
                // The players have won
                Console.WriteLine("The players have won!");
            }
        }
    }
}


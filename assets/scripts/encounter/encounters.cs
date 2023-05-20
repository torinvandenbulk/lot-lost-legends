using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encounters
{
    public class Encounters
    {
        public static void GenerateEncounter(int level, DungeonPath path)
        {
            // Randomly select a biome
            var biome = Enumerable.Range(0, 100).Select(x => (Biome)x).Random();

            // Get the list of NPCs for the biome
            var npcs = GetNPCs(biome);

            // Randomly select a number of NPCs
            var numNPCs = Enumerable.Range(1, 10).Select(x => x).Random();

            // Create a list of the NPCs for the encounter
            var encounter = new List<NPC>();
            for (int i = 0; i < numNPCs; i++)
            {
                encounter.Add(npcs[i]);
            }

            // Calculate the challenge rating of the encounter
            var cr = CalculateCR(encounter);

            // Get the next location on the dungeon path
            var nextLocation = path.GetNextLocation();

            // Add the encounter to the dungeon path
            path.AddEncounter(nextLocation, encounter);

            // Print the encounter details
            Console.WriteLine("Encounter:");
            Console.WriteLine("Biome: " + biome);
            Console.WriteLine("Number of NPCs: " + numNPCs);
            Console.WriteLine("Challenge Rating: " + cr);

            // Print the details of each NPC
            foreach (var npc in encounter)
            {
                Console.WriteLine(npc);
            }
        }

        private static List<NPC> GetNPCs(Biome biome)
        {
            // Load the NPC data
            var npcData = JsonConvert.DeserializeObject<List<NPC>>(File.ReadAllText("npc.json"));

            // Get the list of NPCs for the biome
            var filteredNPCs = npcData.Where(npc => npc.Biome == biome).ToList();

            // Return the list of NPCs
            return filteredNPCs;
        }

        private static int CalculateCR(List<NPC> encounter)
        {
            // Calculate the total challenge rating of the encounter
            int cr = 0;
            foreach (var npc in encounter)
            {
                cr += npc.CR;
            }

            // Return the challenge rating
            return cr;
        }
    }

    public enum Biome
    {
        Forest,
        Desert,
        Mountain,
        Swamp,
        Tundra
    }

    public class NPC
    {
        public string Name { get; set; }
        public Biome Biome { get; set; }
        public int CR { get; set; }
    }

    public class DungeonPath
    {
        public List<Location> Locations { get; set; }

        public DungeonPath()
        {
            Locations = new List<Location>();
        }

        public void AddLocation(Location location)
        {
            Locations.Add(location);
        }

        public Location GetNextLocation()
        {
            return Locations[0];
        }
    }

    public class Location
    {
        public string Name { get; set; }
        public List<Encounter> Encounters { get; set; }

        public Location(string name)
        {
            Name = name;
            Encounters = new List<Encounter>();
        }

        public void AddEncounter(Encounter encounter)
        {
            Encounters.Add(encounter);
        }
    }

    public class Encounter
    {
        public List<NPC> NPCs { get; set; }

        public Encounter(List<NPC> npcs)
        {
            NPCs = npcs;
        }
    }
}

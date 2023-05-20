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
            // Get the dungeon from the path
            var dungeon = path.GetNextDungeon();

            // Generate an encounter for the dungeon
            var encounter = GenerateEncounter(dungeon.Level);

            // Add the encounter to the dungeon path
            path.AddEncounter(dungeon, encounter);

            // Print the encounter details
            Console.WriteLine("Encounter:");
            Console.WriteLine("Biome: " + dungeon.Biome);
            Console.WriteLine("Number of NPCs: " + encounter.NPCs.Count);
            Console.WriteLine("Challenge Rating: " + encounter.CR);

            // Print the details of each NPC
            foreach (var npc in encounter.NPCs)
            {
                Console.WriteLine(npc);
            }
        }

        private static Encounter GenerateEncounter(int level)
        {
            // Get the list of encounters for the level
            var encounters = dungeon.Encounters.Where(encounter => encounter.Level <= level).ToList();

            // Randomly select an encounter
            var encounter = encounters[Random.Next(encounters.Count)];

            // Return the encounter
            return encounter;
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

    public class Dungeon
    {
        public string Name { get; set; }
        public Biome Biome { get; set; }
        public int Level { get; set; }
        public int Length { get; set; }
        public List<Encounter> Encounters { get; set; }

        public Dungeon(string name, Biome biome, int level, int length)
        {
            Name = name;
            Biome = biome;
            Level = level;
            Length = length;
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
        public int CR { get; set; }

        public Encounter(List<NPC> npcs)
        {
            NPCs = npcs;
        }
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
}

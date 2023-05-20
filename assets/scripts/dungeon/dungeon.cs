using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dungeons
{
    public class Dungeons
    {
        public static List<Dungeon> GetDungeons(Biome biome)
        {
            // Load the dungeon data
            var dungeonData = JsonConvert.DeserializeObject<List<Dungeon>>(File.ReadAllText("dungeons.json"));

            // Get the list of dungeons for the biome
            var filteredDungeons = dungeonData.Where(dungeon => dungeon.Biome == biome).ToList();

            // Return the list of dungeons
            return filteredDungeons;
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

        public Encounter(List<NPC> npcs)
        {
            NPCs = npcs;
        }
    }
}

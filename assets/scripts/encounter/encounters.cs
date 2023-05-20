public class Encounters
{
    public static List<Encounter> EncountersList { get; set; } = new List<Encounter>();

    public Encounters()
    {
        EncountersList.Add(new Encounter("Bandits", 1, 1));
        EncountersList.Add(new Encounter("Goblins", 2, 2));
        EncountersList.Add(new Encounter("Orcs", 3, 3));
        EncountersList.Add(new Encounter("Trolls", 4, 4));
    }

    public static Encounter GetEncounter(int dungeonPathLength)
    {
        // Generate a random number between 1 and the length of the dungeon path.
        int randomNumber = Convert.ToInt32(Math.Round(Math.Random() * dungeonPathLength));

        // Return the encounter at the specified index.
        return EncountersList[randomNumber];
    }
}

public class Encounter
{
    public string Name { get; set; }
    public int Number { get; set; }
    public int Difficulty { get; set; }

    public Encounter(string name, int number, int difficulty)
    {
        Name = name;
        Number = number;
        Difficulty = difficulty;
    }
}

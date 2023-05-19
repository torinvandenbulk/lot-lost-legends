public class Armor : Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int AC { get; set; }

    public Armor()
    {
        Name = "";
        Description = "";
        AC = 0;
    }

    public Armor(string name, string description, int AC)
        : this()
    {
        Name = name;
        Description = description;
        AC = AC;
    }
}

// List of basic D&D starting armor

public static Armor Chainmail = new Armor("Chainmail", "A type of armor that provides an AC of 16.", 16);
public static Armor Plate = new Armor("Plate", "A type of armor that provides an AC of 18.", 18);

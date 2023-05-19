public class Consumable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Effect { get; set; }

    public Consumable()
    {
        Name = "";
        Description = "";
        Effect = 0;
    }

    public Consumable(string name, string description, int effect)
        : this()
    {
        Name = name;
        Description = description;
        Effect = effect;
    }

    public void Use()
    {
        // Apply the effect to the user.
        Console.WriteLine("You used the " + Name + " and it had the following effect: " + Description);
    }
}

// List of basic D&D starting consumable items

public static Consumable Healing Potion = new Consumable("Healing Potion", "A potion that restores 2d4 hit points.", 2d4);
public static Consumable Mana Potion = new Consumable("Mana Potion", "A potion that restores 2d4 mana points.", 2d4);

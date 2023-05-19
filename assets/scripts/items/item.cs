public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Item()
    {
        Name = "";
        Description = "";
    }

    public Item(string name, string description)
    {
        Name = name;
        Description = description;
    }
}

public class Weapon : Item
{
    public int Damage { get; set; }

    public Weapon()
    {
        DamageType = "";
    }

    public Weapon(string name, string description, int damage, string damageType)
        : base(name, description, damage)
    {
        DamageType = damageType;
    }

    public void Use()
    {
        // Prompt the user to roll a die.
        Console.WriteLine("Roll a die to determine the damage.");
        int damage = Convert.ToInt32(Console.ReadLine());

        // Calculate the total damage.
        int totalDamage = damage + this.Damage;

        // Display the damage.
        Console.WriteLine("You rolled a " + damage + ", for a total damage of " + totalDamage + ".");
    }
}

public class Armor : Item
{
    public int AC { get; set; }

    public Armor()
    {
        AC = 0;
    }

    public Armor(string name, string description, int AC)
        : base(name, description)
    {
        AC = AC;
    }
}

public class Consumable : Item
{
    public void Use()
    {
        // TODO: Implement the use function for this consumable item.
    }
}

// List of basic D&D starting weapons

public static Weapon Dagger = new Weapon("Dagger", "A small, one-handed weapon that deals 1d4 piercing damage.", 1, "piercing");
public static Weapon Shortsword = new Weapon("Shortsword", "A one-handed weapon that deals 1d6 piercing damage.", 1, "piercing");
public static Weapon Longsword = new Weapon("Longsword", "A two-handed weapon that deals 1d8 slashing damage.", 2, "slashing");
public static Weapon Greataxe = new Weapon("Greataxe", "A two-handed weapon that deals 1d12 slashing damage.", 3, "slashing");

// List of basic D&D starting armor

public static Armor Chainmail = new Armor("Chainmail", "A type of armor that provides an AC of 16.", 16);
public static Armor Plate = new Armor("Plate", "A type of armor that provides an AC of 18.", 18);

// List of basic D&D starting consumable items

public static Consumable Healing Potion = new Consumable("Healing Potion", "A potion that restores 2d4 hit points.", 2d4);
public static Consumable Mana Potion = new Consumable("Mana Potion", "A potion that restores 2d4 mana points.", 2d4);

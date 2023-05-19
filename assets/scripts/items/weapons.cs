public class Weapon
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Damage { get; set; }
    public string DamageType { get; set; }

    public Weapon()
    {
        Name = "";
        Description = "";
        Damage = 0;
        DamageType = "";
    }

    public Weapon(string name, string description, int damage, string damageType)
        : this()
    {
        Name = name;
        Description = description;
        Damage = damage;
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

// List of basic D&D starting weapons

public static Weapon Dagger = new Weapon("Dagger", "A small, one-handed weapon that deals 1d4 piercing damage.", 1, "piercing");
public static Weapon Shortsword = new Weapon("Shortsword", "A one-handed weapon that deals 1d6 piercing damage.", 1, "piercing");
public static Weapon Longsword = new Weapon("Longsword", "A two-handed weapon that deals 1d8 slashing damage.", 2, "slashing");
public static Weapon Greataxe = new Weapon("Greataxe", "A two-handed weapon that deals 1d12 slashing damage.", 3, "slashing");

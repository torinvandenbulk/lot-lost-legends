public class Enemy
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int AC { get; set; }
    public int HP { get; set; }
    public List<Attack> Attacks { get; set; }
    public BaseStats BaseStats { get; set; }

    public Enemy(string name, string description, int AC, int HP, List<Attack> attacks, BaseStats baseStats)
    {
        Name = name;
        Description = description;
        AC = AC;
        HP = HP;
        Attacks = attacks;
        BaseStats = baseStats;
    }

    public void Attack(Character character)
    {
        // Choose an attack from the list of attacks.
        int attackIndex = Random.Next(Attacks.Count);
        Attack attack = Attacks[attackIndex];

        // Roll the attack.
        int attackRoll = Random.Next(20) + attack.Modifier;

        // If the attack hits, deal damage.
        if (attackRoll >= character.AC)
        {
            int damage = attack.Damage;
            character.HP -= damage;
        }
    }
}

public class Attack
{
    public string Name { get; set; }
    public int Modifier { get; set; }
    public int Damage { get; set; }

    public Attack(string name, int modifier, int damage)
    {
        Name = name;
        Modifier = modifier;
        Damage = damage;
    }
}

public class BaseStats
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }

    public BaseStats(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
    {
        Strength = strength;
        Dexterity = dexterity;
        Constitution = constitution;
        Intelligence = intelligence;
        Wisdom = wisdom;
        Charisma = charisma;
    }
}

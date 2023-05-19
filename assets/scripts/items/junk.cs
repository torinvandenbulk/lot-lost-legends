public class Junk
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int SellPrice { get; set; }

    public Junk()
    {
        SellPrice = 0;
    }

    public Junk(string name, string description, int sellPrice)
        : base(name, description)
    {
        SellPrice = sellPrice;
    }

    public override void Use()
    {
        // Do nothing.
    }

    // List of junk items

    public static Junk BrokenSword = new Junk("Broken Sword", "A sword that is no longer functional.", 10);
    public static Junk RustyShield = new Junk("Rusty Shield", "A shield that is covered in rust.", 20);
    public static Junk TornCloak = new Junk("Torn Cloak", "A cloak that is torn and no longer wearable.", 15);
    public static Junk WorthlessGem = new Junk("Worthless Gem", "A gem that is worthless.", 5);
    public static Junk PieceOfDriftwood = new Junk("Piece of Driftwood", "A piece of driftwood that is no longer useful.", 10);
}

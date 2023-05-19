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
        : this()
    {
        Name = name;
        Description = description;
    }
}


public class CharInventory
{
    public Dictionary<string, Item> items = new Dictionary<string, Item>();

    public void AddItem(Item item)
    {
        items.Add(item.Name, item);
    }

    public void RemoveItem(string itemName)
    {
        items.Remove(itemName);
    }

    public Item GetItem(string itemName)
    {
        return items[itemName];
    }

    public bool HasItem(string itemName)
    {
        return items.ContainsKey(itemName);
    }

    public int GetItemCount()
    {
        return items.Count;
    }
    
    public void RemoveItemFromInventory(string itemName)
    {
        // Check if the item is in the inventory.
        if (!HasItem(itemName))
        {
            // The item is not in the inventory.
            return;
        }

        // Prompt the user to confirm that they want to remove the item.
        Console.WriteLine("Are you sure you want to remove the item " + itemName + " from your inventory?");
        string response = Console.ReadLine();

        // If the user says yes, remove the item from the inventory.
        if (response.Equals("yes"))
        {
            RemoveItem(itemName);
        }
    }
}

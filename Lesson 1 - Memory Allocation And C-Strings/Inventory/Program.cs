// Exercise
// Make a new class called "Inventory" that holds the player's items in a collection
// The user should only be able to hold 5 of each item
// The class should implement the following functions:
// bool AddItem(Item newItem)
// bool RemoveItem(string id)
// bool HasItem(string id)
// int GetItemCount(string id)

public class Program
{
    public static void Main(string[] args)
    {
        Item dagger = new Item("item_dagger", "Dagger");
        Item benadryl = new Item("item_benadryl", "100 Benadryl in a Baggie");
        Item bigSword = new Item("item_big_sword", "Big Sword");

        Inventory inventory = new Inventory();

        inventory.AddItem(dagger);
        inventory.AddItem(dagger);
        inventory.AddItem(dagger);
        inventory.AddItem(dagger);
        inventory.AddItem(dagger);

        inventory.AddItem(benadryl);
        inventory.AddItem(benadryl);
        inventory.AddItem(benadryl);
        inventory.AddItem(benadryl);
        inventory.AddItem(benadryl);
        inventory.AddItem(benadryl);

        inventory.AddItem(bigSword);
        inventory.AddItem(bigSword);
        inventory.AddItem(bigSword);

        for (int i = 0; i < inventory.GetNumberOfItems(); i++)
        {

        }
    }
}
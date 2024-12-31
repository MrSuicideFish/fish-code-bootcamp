
using System.Collections.Immutable;

public class Inventory
{
    List<string> typesOfItems = new List<string>();
    List<int> count = new List<int>();
    
    public bool AddItem(Item newItem)
    {
        if(newItem == null 
        || string.IsNullOrEmpty(newItem.Id))
        {
            return false;
        }

        int index = -1;
        for(int i = 0; i < typesOfItems.Count; i++)
        {
            if(typesOfItems[i] == newItem.Id)
            {
                index = i;
                break;
            }
        }

        if (index >= 0)
        {
            if (count[index] >= 5)
            {
                return false;
            }

            count[index]++;
        }
        else
        {
            typesOfItems.Add(newItem.Id);
            count.Add(1);
            index = typesOfItems.Count - 1;
        }

        return true;
    }

    public bool RemoveItem(string itemId)
    {
        if (string.IsNullOrEmpty(itemId))
        {
            return false;
        }

        int index = -1;
        for (int i = 0; i < typesOfItems.Count; i++)
        {
            if (typesOfItems[i] == itemId)
            {
                index = i;
                break;
            }
        }

        if (index < 0)
        {
            return false;
        }

        if (count[index] == 1)
        {
            typesOfItems.RemoveAt(index);
            count.RemoveAt(index);
        }
        else
        {
            count[index]--;
        }

        return true;
    }

    public bool HasItem(string itemId)
    {
        for (int i = 0; i < typesOfItems.Count; i++)
        {
            if (typesOfItems[i] == itemId)
            {
                return true;
            }
        }
        return false;
    }

    public int GetItemCount(string itemId)
    {
        if (string.IsNullOrEmpty(itemId))
        {
            return 0;
        }

        int index = -1;
        for (int i = 0; i < typesOfItems.Count; i++)
        {
            if(typesOfItems[i] == itemId)
            {
                index = i;
                break;
            }
        }

        if(index < 0)
        {
            return 0;
        }

        return count[index];
    }

    public int GetNumberOfItems()
    {
        return typesOfItems.Count;
    }
}
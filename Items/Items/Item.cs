using System.Reflection.Metadata;
using Items.People;

namespace Items;

public class Item
{
    protected int ItemID { get; set; }
    protected string ItemName { get; set; }

    public Item(int itemId, string itemName)
    {
        ItemID = itemId;
        ItemName = itemName;
    }

    public int GetId()
    {
        return ItemID;
    }

}
using System.Reflection.Metadata;
using Items.People;

namespace Items;

public class Item
{
    protected int ItemID { get; set; }
    protected string ItemName { get; set; }
    
    private Person User { get; set; }
    private DateTime? BorrowedDate { get; set; }
    private DateTime? ReturnDate { get; set; }

    public Item(int itemId, string itemName)
    {
        ItemID = itemId;
        ItemName = itemName;
    }

    public void BorrowItem(int itemId, Person user, DateTime borrowedDate)
    {
        ItemID = itemId;
        User = user;
        BorrowedDate = borrowedDate;
        ReturnDate = null;
    }

    public int GetId()
    {
        return ItemID;
    }
}
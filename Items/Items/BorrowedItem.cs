using Items.People;

namespace Items;

public class BorrowedItem
{
    private int ItemID { get; set; }
    private Person User { get; set; }
    private DateTime? BorrowedDate { get; set; }
    private DateTime? ReturnDate { get; set; }
    
    public BorrowedItem(int itemId, Person user, DateTime borrowedDate)
    {
        ItemID = itemId;
        User = user;
        BorrowedDate = borrowedDate;
        ReturnDate = null;
    }

    
}
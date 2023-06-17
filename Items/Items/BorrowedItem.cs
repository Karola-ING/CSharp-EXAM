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

    public int GetId()
    {
        return ItemID;
    }
    
    public Person GetUser()
    {
        return User;
    }
    
    public DateTime? GetBorrowDate()
    {
        return BorrowedDate;
    }
    
    public string GetReturnDate()
    {
        string message;
        if (ReturnDate == null)
        {
            message = "Not returned yet";
            return message;
        }
        else
        {
            message = Convert.ToString(ReturnDate);
            return message;
        }

        
    }
}
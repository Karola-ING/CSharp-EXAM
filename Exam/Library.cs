using Items;
using Items.People;

namespace Exam;

public class Library
{
    private List<Person> users;
    private List<Item> items;
    private List<BorrowedItem> borrowedItems;

    public Library()
    {
        users = new List<Person>();
        items = new List<Item>();
        borrowedItems = new List<BorrowedItem>();
    }

    public void AddUser(Person user)
    {
        users.Add(user);
    }
    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void BorrowItem(int itemID, Person user, DateTime borrowedDate)
    {
        Item itemToBorrow = items.Find(x => x.GetId() == itemID);
        if (user.CanBorrowItems())
        {
            BorrowedItem borrowItem = new BorrowedItem(itemID, user, borrowedDate);
            borrowedItems.Add(borrowItem);
        }
        else
        {
            Console.WriteLine($"{user.GetName()} cannot borrow more items.");
        }
        
    }

    public void GetBorrowedItems()
    {
        foreach (var borrowedItem in borrowedItems)
        {
            Console.WriteLine(
                $"ID: {borrowedItem.GetId()}, User who borrowed it: {borrowedItem.GetUser().GetName()}, " +
                $"Borrowing Date: {borrowedItem.GetBorrowDate()}, Return date: {borrowedItem.GetReturnDate()}."
            );
        }
    }

}
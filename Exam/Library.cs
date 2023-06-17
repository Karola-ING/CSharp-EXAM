using Items;
using Items.People;

namespace Exam;

public class Library
{
    private List<Person> users;
    private List<Item> borrowedItems;

    public Library()
    {
        users = new List<Person>();
        borrowedItems = new List<Item>();
    }

    public void AddUser(Person user)
    {
        users.Add(user);
    }

    public void BorrowItem(int itemID, string name, Person user, DateTime borrowedDate)
    {
        if (user.CanBorrowItems())
        {
            Item borrowItem = new Item(itemID, name);
            borrowItem.BorrowItem(itemID, user,borrowedDate);
            borrowedItems.Add(borrowItem);
        }
        Console.WriteLine("This user cannot borrow more items.");
    }


    

}
namespace Items;

public class Book : Item
{
    private int PageNum { get; set; }
    
    public Book(int itemId, string itemName) : base(itemId, itemName)
    {
    }
}
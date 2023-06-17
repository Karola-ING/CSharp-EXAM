namespace Items;

public class Book : Item
{
    private int PageNum { get; set; }
    private Genre Genre { get; set; }
    
    public Book(int itemId, string itemName, int pageNum, Genre genre) : base(itemId, itemName)
    {
        PageNum = pageNum;
        Genre = genre;
    }
}
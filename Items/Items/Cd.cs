namespace Items;

public class Cd : Item

{
    private int Tracks { get; set; }
    
    public Cd(int itemId, string itemName, int tracks) : base(itemId, itemName)
    {
        Tracks = tracks;
    }
}
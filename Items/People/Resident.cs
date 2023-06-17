namespace Items.People;

public class Resident : Person
{
    private int MaxItemsToBorrow = 3;
    private int MaxDaysBorrow = 7;
    
    public Resident(int personId, string personName) : base(personId, personName)
    {
        this.ItemsToBorrow = MaxItemsToBorrow;
        this.DaysBorrow = MaxDaysBorrow;
    }
}
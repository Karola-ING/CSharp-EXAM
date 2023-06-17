namespace Items.People;

public class Student : Person
{
    private int MaxItemsToBorrow = 5;
    private int MaxDaysBorrow = 14;
    
    public Student(int peopleId, string peopleName) : base(peopleId, peopleName)
    {
        this.ItemsToBorrow = MaxItemsToBorrow;
        this.DaysBorrow = MaxDaysBorrow;
    }
}
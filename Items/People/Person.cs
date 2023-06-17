namespace Items.People;

public class Person
{
    protected int ItemsToBorrow;
    protected int DaysBorrow;

    protected int LateReturning;
    private int MaxLateReturning = 3;

    private bool IsBlocked = false;
    private bool CanBorrow = true;
    private int PersonID { get; set; }
    private string PersonName { get; set; }

    public Person(int personId, string personName)
    {
        PersonID = personId;
        PersonName = personName;
        LateReturning = 0;
    }

    public void BlockPerson()
    {
        if (LateReturning == MaxLateReturning)
        {
            this.IsBlocked = true;
            this.CanBorrow = false;
        }
    }

    public bool CanBorrowItems()
    {
        if (IsBlocked)
        {
            this.CanBorrow = false;
            return false;
        }

        if (CanBorrow == false)
        {
            return false;
        }

        if (LateReturning < MaxLateReturning)
        {
            return true;
        }

        return true;
    }
    
    public void LateReturningOfItem()
    {
        //TODO 
    }

    public void BorrowItem()
    {
        
    }


}
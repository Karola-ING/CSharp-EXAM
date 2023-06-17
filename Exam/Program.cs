using Items.People;

namespace Exam;

public class Program
{
    public static void Main(string[] args)
    {
        Resident resident = new Resident(123, "Adam Mickiewicz");
        Student student = new Student(456, "Juliusz Słowacki");

        Library library = new Library();
        
        library.AddUser(resident);
        library.AddUser(student);
        
        library.BorrowItem(1, "Nirvana CD", resident, DateTime.Now.AddDays(-5));

        Console.ReadLine();

    }
}
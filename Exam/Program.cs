using Items;
using Items.People;

namespace Exam;

public class Program
{
    public static void Main(string[] args)
    {
        Resident resident = new Resident(123, "Adam Mickiewicz");
        Student student = new Student(456, "Juliusz Słowacki");

        Cd cd = new Cd(1, "Nirvana", 8);
        Book book = new Book(2, "Wuthering Heights", 256, Genre.Nonfiction);

        Library library = new Library();
        
        library.AddUser(resident);
        library.AddUser(student);
        
        library.AddItem(cd);
        library.AddItem(book);

        foreach (var borrowedItem in library.GetBorrowedItems())
        {
            Console.WriteLine(borrowedItem);
        }

    }
}
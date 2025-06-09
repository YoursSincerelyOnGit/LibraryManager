using LibraryManager;
using static LibraryManager.LibraryItem;

class Program
{
    private static List<LibraryItem> libraryItems = new List<LibraryItem>();

    static void AddItem()
    {
        Console.WriteLine("Select item type: 1. Book, 2. Magazine, 3. DVD");
        string type = Console.ReadLine();

        Console.Write("Enter ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
            throw new ArgumentException("Invalid ID.");

        if (libraryItems.Any(item => item.ID == id))
            throw new ArgumentException("ID already exists.");

        Console.Write("Enter Title: ");
        string title = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty.");

        Console.Write("Enter Year Published: ");
        if (!int.TryParse(Console.ReadLine(), out int year) || year < 0)
            throw new ArgumentException("Invalid year.");

        switch (type)
        {
            case "1": // Book
                Console.Write("Enter Author: ");
                string author = Console.ReadLine();
                Console.Write("Enter Genre: ");
                string genre = Console.ReadLine();
                libraryItems.Add(new Book(id, title, year, author, genre));
                break;
            case "2": // Magazine
                Console.Write("Enter Issue Number: ");
                if (!int.TryParse(Console.ReadLine(), out int issue))
                    throw new ArgumentException("Invalid issue number.");
                Console.Write("Enter Month: ");
                string month = Console.ReadLine();
                libraryItems.Add(new Magazine(id, title, year, issue, month));
                break;
            case "3": // DVD
                Console.Write("Enter Director: ");
                string director = Console.ReadLine();
                Console.Write("Enter Duration (minutes): ");
                if (!int.TryParse(Console.ReadLine(), out int duration))
                    throw new ArgumentException("Invalid duration.");
                libraryItems.Add(new DVD(id, title, year, director, duration));
                break;
            default:
                throw new ArgumentException("Invalid item type.");
        }
        Console.WriteLine("Item added successfully.");
    }

    static void RemoveItem()
    {
        Console.Write("Enter ID to remove: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
            throw new ArgumentException("Invalid ID.");

        int removed = libraryItems.RemoveAll(item => item.ID == id);
        if (removed > 0)
            Console.WriteLine("Item removed successfully.");
        else
            Console.WriteLine("Item not found.");
    }

    static void SearchItem()
    {
        Console.Write("Enter ID to search: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
            throw new ArgumentException("Invalid ID.");

        var item = libraryItems.FirstOrDefault(item => item.ID == id);
        if (item != null)
            Console.WriteLine(item);
        else
            Console.WriteLine("Item not found.");
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Search Item");
            Console.WriteLine("4. Display All Items");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            try
            {
                switch (choice)
                {
                    case "1": AddItem(); break;
                    case "2": RemoveItem(); break;
                    case "3": SearchItem(); break;
                    //case "4": DisplayAllItems(); break;
                    case "5": return;
                    default: Console.WriteLine("Invalid choice. Try again."); break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
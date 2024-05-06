public class Menu 
{
    public int bringMenu()
    {   
        Console.WriteLine();
        Console.WriteLine("Hello Welcome to myJournal Made Easy");
        Console.WriteLine("<< Please choose an action");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do (enter just the number): ");
        string userEntry = Console.ReadLine();
        int userEntryConverted = int.Parse(userEntry);
        return userEntryConverted;
    }
}
public class MindfulMenu
{   
    /*This class is responsible for displaying the menu, 
    taking input for action and converting the input(string) to integer and 
    return the input as an int*/
    private int _userAction;

    public int DispalyMenu()
    {
        Console.WriteLine("Which Activity would you like to particitpate? enter just the number: ");
        Console.WriteLine();
        Console.WriteLine("1 - Breathing Activity");
        Console.WriteLine("2 - Reflection Activity");
        Console.WriteLine("3 - Listing Activity");
        Console.WriteLine("4 - quit");
        Console.WriteLine();
        Console.Write("Enter just the number >> ");
        string MenuActivity = Console.ReadLine();
        //converting
        int convertMenuActivity = int.Parse(MenuActivity);
        _userAction = convertMenuActivity;
        return _userAction;
            
    }
}
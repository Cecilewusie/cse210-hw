public class Entry
{   
    //This class will hold date
    //keep track of the date, prompt text, and the text of the entry itself.
    //This class represents a single journal entery
    public string _date;
    public string _promtText;
    public string _entryText;

    public void DisplayEntry()
    {
        //Displaying the entry to the terminal window
        Console.WriteLine($"{_date}, {_promtText}");
        Console.WriteLine(_entryText);
    }

}
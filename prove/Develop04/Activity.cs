using System.Diagnostics;

public class Activity
{
    /*display stating message
    will be responsible for the animation/ countdown
    will be responsiible for displaying the ending message*/

    private string _name;
    private string _description;
    protected int _duration;
    private string _endingMessage;

    public Activity(string name,string description, string endingMessage)
    {
        _name = name;
        _description = description;
        _endingMessage = endingMessage;
    }

    //behaviors or methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine(_name.ToUpper());

        Console.WriteLine();
        Console.WriteLine(_description);

        Console.WriteLine();
        Console.WriteLine("How long in seconds, do you want to hold this session eg 30: ");
        string  duration = Console.ReadLine();
        int durationInt = int.Parse(duration);
        _duration = durationInt;
        Console.WriteLine($"your program is going to last {_duration} seconds");       

    }
    public void DispalyEndingMessage()
    {
        Console.WriteLine(_endingMessage);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> AnimationSpin = new List<string>();
        AnimationSpin.Add("|");
        AnimationSpin.Add("/");
        AnimationSpin.Add("-");
        AnimationSpin.Add("\\");
        AnimationSpin.Add("|");
        AnimationSpin.Add("/");
        AnimationSpin.Add("-");
        AnimationSpin.Add("\\");

        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(8);

        int i = 0;
        while (StartTime < EndTime)
        {
            string s = AnimationSpin[i];
            Console.Write(s);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            i++;

            if (i == AnimationSpin.Count)
            {
                break; 
            }
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }

    }


}
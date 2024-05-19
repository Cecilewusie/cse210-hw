using System.Diagnostics;

public class Activity
{
    /*display stating message
    will be responsible for the animation/ countdown
    will be responsiible for displaying the ending message*/

    private string _name;
    private string _description;
    private int _duration;
    private string _endingMessage;

    public Activity(string name,string description, int duration, string endingMessage)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _endingMessage = endingMessage;
    }

    //behaviors or methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_description);
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
        DateTime EndTIme = StartTime.AddSeconds(8);

        int i = 0;
        while (StartTime < EndTIme)
        {
            string s = AnimationSpin[i];
            Console.Write(s);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            i++;

            if (i == AnimationSpin.Count)
            {
                i = 0; 
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
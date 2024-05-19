using System;

public class ActivityInfo
{
    private int _action;
    private string _name;
    private string _description;

    public ActivityInfo(int action)
    {
        _action = action;
    }

    public int GetDuration()
    {

        Console.WriteLine("Enter the duration of the program. eg 30: ");
        string  duration = Console.ReadLine();
        int durationInt = int.Parse(duration);
        return durationInt;

    }    

    public string GetName()
    {
        if (_action == 1)
        {
            _name = "This is the Breathing Activity";
        }
        else if (_action == 2)
        {
            _name = "This is the Reflection Activity";
        }
        else if (_action == 3)
        {
            _name = "This is the Listing Activity";
        }
        return _name;
    }

    public string GetMessage()
    {
        if (_action == 1)
        {
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }
        else if (_action == 2)
        {
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }
        else if (_action == 3)
        {
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }
        return _description;
    }

    public string GetEndingMessage()
    {
        return "Goodluck, you did a great job.";
    }
}

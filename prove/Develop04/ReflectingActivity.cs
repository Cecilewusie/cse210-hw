using System;
using System.Collections.Generic;
using System.Linq;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _usedPrompts = new List<string>();
    private List<string> _usedQuestions = new List<string>();

    public ReflectingActivity(string name, string description, string endingMessage) : base(name, description, endingMessage)
    {
        InitializePromptsAndQuestions();
    }

    private void InitializePromptsAndQuestions()
    {
        _prompts.Add("-------Think of a time when you stood up for someone else.-------");
        _prompts.Add("-------Think of a time when you did something really difficult.----------");
        _prompts.Add("-------Think of a time when you helped someone in need.-----------");
        _prompts.Add("-------Think of a time when you did something truly selfless.---------");

        _questions.Add(">> Why was this experience meaningful to you?");
        _questions.Add(">> Have you ever done anything like this before?");
        _questions.Add(">> How did you get started?");
        _questions.Add(">> How did you feel when it was complete?");
        _questions.Add(">> What made this time different than other times when you were not as successful?");
        _questions.Add(">> What is your favorite thing about this experience?");
        _questions.Add(">> What could you learn from this experience that applies to other situations?");
        _questions.Add(">> What did you learn about yourself through this experience?");
        _questions.Add(">> How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        DisplayPrompt();
        DisplayQuestions();    
    }

    private string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            // All prompts have been used, reset for next session
            _prompts.AddRange(_usedPrompts);
            _usedPrompts.Clear();
        }

        int randomIndex = new Random().Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        _prompts.RemoveAt(randomIndex);
        _usedPrompts.Add(randomPrompt);

        return randomPrompt;
    }

    private string GetRandomQuestion()
    {
        if (_questions.Count == 0)
        {
            // All questions have been used, reset for next session
            _questions.AddRange(_usedQuestions);
            _usedQuestions.Clear();
        }

        int randomIndex = new Random().Next(_questions.Count);
        string randomQuestion = _questions[randomIndex];
        _questions.RemoveAt(randomIndex);
        _usedQuestions.Add(randomQuestion);

        return randomQuestion;
    }

    private void DisplayPrompt()
    {
        //displaying the prompt question to the user
        Console.WriteLine("get ready...");
        ShowSpinner(900);

        Console.WriteLine();
        Console.WriteLine(GetRandomPrompt());
        
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter key. ");
        Console.ReadLine();
        Console.Clear();
    }
    private void DisplayQuestions()
    {   
        DateTime startTime = DateTime.Now;
        DateTime endTIme = startTime.AddSeconds(_duration);

        Console.WriteLine();
        Console.WriteLine("Starting in..");
        ShowCountDown(1000);

        while (DateTime.Now < endTIme)
        {   
            Console.WriteLine();
            Console.Write($"{GetRandomQuestion()} ");
            ShowSpinner(2000);
        }
        Console.WriteLine();
        ShowSpinner(1000);
        DispalyEndingMessage();
    }
}

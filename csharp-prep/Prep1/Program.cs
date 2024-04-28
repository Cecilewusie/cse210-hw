using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("what is your last name: ");
        string LastName = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Your name is {LastName}, {firstName} {LastName}.");
    }
}
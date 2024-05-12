using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press the enter key to continue or type 'quit' to end the program.");
        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "quit")
        {
            // Define your scripture here
            Scripture scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world...");

            Console.WriteLine(scripture.GetDisplayText());
            Console.Clear();

            // Hide a few random words
            scripture.HideRandomWord(3); // You can change the number of words to hide
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press the enter key to continue or type 'quit' to end the program.");
            userInput = Console.ReadLine();
        }
    }
}

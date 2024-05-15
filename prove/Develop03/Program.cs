using System;
using System.Collections.Generic;
using System.Linq;

class Program
{   
    static void Main(string[] args)
    {   
        //EXCEEDED REQUIREMENTS
        //Made the program so the user manually inputs their scripture they prefer to memorize



        Console.WriteLine("WELCOME TO SCRIPTURE MEMORIZER APP");

        Console.WriteLine(">>Press the enter key to continue or type 'quit' to end the program.");
        string userInput = Console.ReadLine();

        Console.WriteLine(">>Does this scripture include verse range eng, vrs 2-4, enter yes/no? "); 
        string askVerseRange = Console.ReadLine();
        
        //declaring the scripture object outide of the if statement and assigning it to null at the moment
        //value for the scripture object will be taken in the if block
        Scripture scripture = null;    

        //having the user enter their choice of scripture to learn to memorize
        Console.WriteLine(); //this is to provide space so output in terminal looks good
        Console.Write(">>Enter the name of the book you would like to memorize. example John, Proverbs etc: ");
        string bookName = Console.ReadLine();

        //getting the chapter in interger
        Console.WriteLine(); //this is to provide space so output in terminal looks good
        Console.Write(">>Enter chapter, eg 12 :");
        string chapterNumber = Console.ReadLine();
        ConverString converString = new ConverString(chapterNumber);
        int chapterNumberConverted = converString.getInt();

        //getting the startVerse in integer
        Console.WriteLine(); //this is to provide space so output in terminal looks good
        Console.Write(">>Enter the start verse, eg 5 etc: ");
        string verse1 = Console.ReadLine();
        ConverString converString1 = new ConverString(verse1);
        int verse1int = converString1.getInt();

        //getting the text of the scripture
        Console.WriteLine();
        Console.WriteLine("Enter the whole text of the scripture, eg Jesus wept etc: ");
        string scriptText = Console.ReadLine();

        
        if (askVerseRange == "no")
        {
            // declared the scripture object outside the while loop
            scripture = new Scripture(new Reference(bookName, chapterNumberConverted, verse1int), scriptText); 
        }
        
        else if (askVerseRange == "yes")
        {
            Console.Write(">>Enter the end verse: ");
            string verse2 = Console.ReadLine();
            ConverString converString2 = new ConverString(verse2);
            int verse2int = converString2.getInt();

            // declared the scripture object outside the while loop
            scripture = new Scripture(new Reference(bookName, chapterNumberConverted, verse1int, verse2int), scriptText);             
        }

       
        //Scripture scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world...");        

        while (!scripture.IsCompletelyHidden() && userInput.ToLower() != "quit")
        {

            Console.WriteLine(scripture.GetDisplayText());
            Console.Clear();

            // Hide a few random words
            scripture.HideRandomWord(3); 
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press the enter key to continue or type 'quit' to end the program.");
            userInput = Console.ReadLine();
        }
    }
}

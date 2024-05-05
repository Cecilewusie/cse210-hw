using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)

    {   
        //creating an empty list to hold various datas
        List<string> randomEntry = new List<string>();
        //List<string> dateAlong = new List<string>();

        //creating an instance and object for the Entry class
        Entry getEntry = new Entry();       
        getEntry._usersEntry = randomEntry;
        //getEntry._addDate = dateAlong;

        //string filename = "";
        //List<Entry> toBeSaved = new List<Entry>();

        //creating an instance and object for the journal class
        Journal newJournal = new Journal();
        //newJournal._filename = filename;
        //newJournal._entry.Add(toBeSaved);




        int userEntryConverted = 0;

        while (userEntryConverted < 5)
        {
            Console.WriteLine("Hello Welcome to myJournal Made Easy");
            Console.WriteLine("<< Please choose an action");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Enter just the number of the action.");
            string userEntry = Console.ReadLine();
            userEntryConverted = int.Parse(userEntry);
        
                 
        
            if (userEntryConverted == 1)
            {   
                //calling the getRandomQuestion and saving the question in a variable named randQ
                string randQ = getEntry.getRandomQuestion();

                //printing the random question to the user
                Console.WriteLine(randQ);

                //getting the users reply
                string prompAnswer = Console.ReadLine();
                
                //adding prompAnswer to a list
                //randomEntry.Add(prompAnswer);

                //calling the date time object
                DateTime theCurrentDateAndTime = DateTime.Now;
                string dateText = theCurrentDateAndTime.ToShortDateString();

                //adding date to a list on its own
                //dateAlong.Add(dateText);

                string dateRandomQuestionPrompAnswer = ($"{dateText} - {randQ} {prompAnswer}");

                randomEntry.Add(dateRandomQuestionPrompAnswer);
            
            }

            else if (userEntryConverted == 2)
            {
                getEntry.displayUserEntry();
            }

            else if (userEntryConverted == 3)
            {
                newJournal.ReadSavedFile();
            }
            
            else if (userEntryConverted == 4)
            {
                Console.WriteLine("Please enter the name of the file you want to save to:");
                string filename = Console.ReadLine();
                newJournal._filename = filename;
                //toBeSaved.Add(getEntry);
                newJournal._entry.Add(getEntry);

                //newJournal.SaveToFIle(newJournal._entry);
                newJournal.SaveToFIle();

            }
            

        }
    }
}
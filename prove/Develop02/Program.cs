using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {   
        //OBJECTS OR INSTANCES CREATION

        //menuobject
        Menu menuObj = new Menu();
        
        //entry object
        

        //jounal object
        Journal journalObj = new Journal();

        //PromptGenerator Object
        PromtGenrator promtGenratorObj = new PromtGenrator();

        //calling date
        DateTime theCurrent  = DateTime.Now;

        
        int userAction = 0;
        while (userAction < 5)
        {
            //calling the bringMenu method and storing its return value in userAction variable
            userAction = menuObj.bringMenu();

            if (userAction == 1)
            {   
                Entry entryObj = new Entry();

                //assigning the value of _date
                string dateText = theCurrent.ToShortDateString();
                entryObj._date = dateText;

                //getting the promtText and assigning value to the _promtText variable in the Entry class
                string promtQues = promtGenratorObj.getRandomPrompt();
                Console.WriteLine(promtQues);
                string promptReply = Console.ReadLine();

                //assigning the promptReply as a value for _entryText variable in the Entry class
                entryObj._entryText = promptReply;

                //assigning the promptQuest as a value for the _promtText
                entryObj._promtText = promtQues;


                journalObj.AddEntry(entryObj);
            }

            else if (userAction == 2)
            {
                journalObj.DisplayAll();
            }

            else if (userAction == 4)
            {
                //getting name of the file
                Console.WriteLine("Please enter the name of the file you want to save to (without file type eg,csv,txt etc): ");
                string rawName = Console.ReadLine();
                string fileName = $"{rawName}.txt";

                //assigning value to the SaveFromFile method
                journalObj.SaveToFile(fileName);

            }

            else if (userAction == 3)
            {
                Console.WriteLine("Enter name of file you want to load from (without file type eg,csv,txt etc): ");
                string rawName = Console.ReadLine();
                string fileName = $"{rawName}.txt";

                //assigning value to the SaveFromFile method
                journalObj.LoadFromFile(fileName);                
            }


        }
    }
}
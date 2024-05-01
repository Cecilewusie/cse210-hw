using System;

class Program
{
    static void Main(string[] args)
    {   
        //calling the displayWelcome function 
        DisplayWelcome();

        //calling the PromptUsersname function
        string userName = PromptUserName();

        //Calling the PromptUserNumber function
        int userNumber = PromptUserNumber();

        // Calling the SquareNumber function by parsing an argument
        // Console.Write("Enter a number to calculate square number for: ");
        // string userInp = Console.ReadLine();
        // int convertedSquare = int.Parse(userInp);

        int squareNum = SquareNumber(userNumber);

        //calling the DisplayResult function
        DisplayResult(userName, squareNum);




        //Display the message, "Welcome to the program"
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program");
        }


        //Asks for and returns the user's name(as a string)
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            return name;
        }
        
        //Asks for and returns the user's favorite number(as an interger)
        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int favoritNum = int.Parse(userInput);

            return favoritNum;
        }

        //Accepts an integer as a parameter and returns that number squared(as an integer)
        static int SquareNumber(int userNumber)
        {
            int square = userNumber * userNumber;

            return square;

        }

        //Accepts the user's name and the squared number and displays them
        static void DisplayResult(string userName, int squareNum)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareNum}");
        }
    }
}
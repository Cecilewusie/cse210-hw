using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade pecentage: ");
        string gradePercentageInString = Console.ReadLine();
        
        //converting string to interger
        int gradePercentageInNumber = int.Parse(gradePercentageInString);
        string Letter = "";

        if (gradePercentageInNumber >= 90)
        {
            Letter = "A";
        }
        else if (gradePercentageInNumber >= 80)
        {
            Letter = "B";
        }

        else if (gradePercentageInNumber >= 70)
        {
            Letter = "C";
        }

       else if (gradePercentageInNumber >= 60)
        {
            Letter = "D";
        }

       else if (gradePercentageInNumber < 60)
        {
            Letter = "C";
        }
        Console.WriteLine(Letter);

        //pass mark should be 70, if student passed, congratulate, if student failed, encourage        
        if (gradePercentageInNumber >=70)
        {
            Console.WriteLine("Congratulations, You passed the course.");
        }
        else
        {
            Console.WriteLine("Do not be discouraged but work harders next time");
        }               

    }
}
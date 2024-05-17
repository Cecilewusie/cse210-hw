using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Cecil Ewusie","Int Science", "7.3", "65-70");
        Console.WriteLine(mathAssignment.getSummary());
        string result = mathAssignment.getHomeworkList();
        Console.WriteLine(result);

        Console.WriteLine("-----------------");

        WritingAssingment writingAssingment = new WritingAssingment("Gregory", "European", "The Causes of the world war II");
        Console.WriteLine(writingAssingment.getSummary());
        string result2  = writingAssingment.GetWritingInformtion();
        Console.WriteLine(result2);
    }
}
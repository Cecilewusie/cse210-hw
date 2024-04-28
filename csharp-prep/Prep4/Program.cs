using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int convertNumber = -1;
        //appending to a new list
        List<int> nums = new List<int>();        

        while (convertNumber != 0)
        {   
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            convertNumber = int.Parse(userResponse);



            if (convertNumber != 0)
            {
                nums.Add(convertNumber);
            }

        }

        int sum = 0;
        foreach (int num in nums)
        {
           sum += num; 
        }
        Console.WriteLine($"The sume is {sum}");

        //calcuting the average of the numbers in the list
        int totalNum = nums.Count;
        float average = sum / totalNum;
        Console.WriteLine($"The average is: {average}");

        //Finding the largest number in the list
        int largest = 0;
        foreach (int check in nums)
        {
            if (check > largest)
            {
                largest = check;
            }
        }
        Console.WriteLine($"The largest is: {largest}");
    }
}
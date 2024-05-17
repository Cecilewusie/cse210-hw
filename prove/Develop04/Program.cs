using System;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("432", "Brigham");
        Console.WriteLine(student.getName());
        Console.WriteLine(student.getNmber());

        Console.WriteLine(student.getstudentInfo());

        

    }
}
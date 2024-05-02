using System;

class Program
{
    static void Main(string[] args)
    {   
        //creating an instance or object for the JobHistory class
        //first instance
        JobHistory Job1 = new JobHistory();
        Job1._company = "Microsoft";
        Job1._jobtitle = "Programmer";
        Job1._startYear = 2010;
        Job1._endYear = 2015;

        //second instance
        JobHistory Job2 = new JobHistory();
        Job2._company = "Bridge Hiring";
        Job2._jobtitle = "Technical Assistance";
        Job2._startYear = 2019;
        Job2._endYear = 2023;

        // //Displaying job information on screen
        // Console.WriteLine();  //this only create space to make print statement in terminal look nice
        // Job1.DisplayHistory();
        // Job2.DisplayHistory();
        // Console.WriteLine();  ////this only create space to make print statement in terminal look nice

        //creating an instance or object for the Resume class
        Resume resumeHist = new Resume();
        resumeHist._name  = "Cecil Ewusie";
        resumeHist._job.Add(Job1);
        resumeHist._job.Add(Job2);

        //calling the method or function in the resumeHist class
        Console.WriteLine();   //this only create space to make print statement in terminal look nice
        resumeHist.DispalyResume();
        Console.WriteLine();   //this only create space to make print statement in terminal look nice

    }
}
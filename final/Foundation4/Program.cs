using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(new DateTime(2024, 06, 26), 30, 3);
        Cycling cycling = new Cycling(new DateTime(2024, 06, 24), 30, 9.7);
        Swimming swimming = new Swimming(new DateTime(2024, 06, 23), 30, 4);

        List<Activity> activities = new List<Activity>() {running, cycling, swimming};

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        } 
    }
}
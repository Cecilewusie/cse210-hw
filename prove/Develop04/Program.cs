using System;

class Program
{
    static void Main(string[] args)
    {
        int userAction = 0;

        int numACtivities = 0;

        while (userAction < 5)
        {
            Console.WriteLine();
            MindfulMenu mindfulMenu = new MindfulMenu();
            int userAction1 = mindfulMenu.DispalyMenu();
            userAction = userAction1;
            ActivityInfo activityInfo = new ActivityInfo(userAction);


            if (userAction == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity(activityInfo.GetName(), activityInfo.GetMessage(), activityInfo.GetEndingMessage());
                breathingActivity.DisplayStartingMessage();
                Console.WriteLine();
                //calling the run method
                breathingActivity.Run();   
            }

            if (userAction == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity(activityInfo.GetName(), activityInfo.GetMessage(), activityInfo.GetEndingMessage());
                reflectingActivity.DisplayStartingMessage();
                Console.WriteLine();

                //calling the run method in the reflectingActivity class
                reflectingActivity.Run();   
            }

            if (userAction == 3)
            {
                ListingActivity listingActivity = new ListingActivity(activityInfo.GetName(), activityInfo.GetMessage(), activityInfo.GetEndingMessage());
                listingActivity.DisplayStartingMessage();
                Console.WriteLine();

                //calling the run method in the listing Activity class
                listingActivity.Run();                
            }

            if (userAction == 4)
            {
                break;
            }

            numACtivities++;
        }

        Console.WriteLine();
        Console.WriteLine($"You successfully performed {numACtivities}, well done");

    }
}
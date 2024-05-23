using System;


class Program
{
    //EXCEEDED REQUIREMENTS BY:
    //1- Making sure no question or prompts is repeated in the reflectingActivity Class
    //2 - Keeping track of all the activies done and displaying it when the program ends
    //3 - Made new class ActivityInfo to hold all the values to be given to the constructors

    static void Main(string[] args)
    {
        int userAction = 0;

        //kepping track of how many activities is performed
        int numOfActivities = 0;

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
                Console.Clear();
                breathingActivity.DisplayStartingMessage();
                Console.WriteLine();
                Console.Clear();
                //calling the run method
                breathingActivity.Run();   
            }

            if (userAction == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity(activityInfo.GetName(), activityInfo.GetMessage(), activityInfo.GetEndingMessage());
                Console.Clear();
                reflectingActivity.DisplayStartingMessage();
                Console.WriteLine();

                //calling the run method in the reflectingActivity class
                reflectingActivity.Run();   
            }

            if (userAction == 3)
            {
                ListingActivity listingActivity = new ListingActivity(activityInfo.GetName(), activityInfo.GetMessage(), activityInfo.GetEndingMessage());
                Console.Clear();
                listingActivity.DisplayStartingMessage();
                Console.WriteLine();
                Console.Clear();

                //calling the run method in the listing Activity class
                listingActivity.Run();                
            }

            if (userAction == 4)
            {
                break;
            }

            numOfActivities++;
        }

        Console.WriteLine();
        Console.WriteLine($"You successfully performed {numOfActivities} activities, well done");

    }
}
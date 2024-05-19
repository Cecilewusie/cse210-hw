using System;

class Program
{
    static void Main(string[] args)
    {
        int userAction = 0;

        while (userAction < 5)
        {
            Console.WriteLine();
            MindfulMenu mindfulMenu = new MindfulMenu();
            int userAction1 = mindfulMenu.DispalyMenu();
            userAction = userAction1;
            ActivityInfo activityInfo = new ActivityInfo(userAction);

            if (userAction == 1)
            {
                Activity activity = new Activity(activityInfo.GetName(), activityInfo.GetMessage(), activityInfo.GetDuration(), activityInfo.GetEndingMessage());
                //activity.ShowCountDown(2000);
                activity.ShowSpinner(1000);
            }
        }

    }
}
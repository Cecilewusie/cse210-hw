using System;
using System.Collections;
using System.Diagnostics;

class Program
{
    //EXCEEDED REQUIREMENTS
    //Added some countdowns when the load and save goal is called to make console look presentable

    static void Main(string[] args)
    {   
        GoalManager goalManager = new GoalManager();

        int userOptionInt = 0;
        while (userOptionInt != 6)
        {
            Console.WriteLine();
            goalManager.Start();
            string userOptionString = Console.ReadLine();
            userOptionInt = int.Parse(userOptionString);

            switch(userOptionInt)
            {
                case 1:
                
                    goalManager.ListGoalNames();
                    string GoalTypeString = Console.ReadLine();
                    int GoalTypeInt = int.Parse(GoalTypeString);
                    
                    //will be simplified
                    //if the GoalTypeInt comes as digit 1
                    //calling the GoalManager and assigning the GoalTYpeInt as parameter
                    goalManager.CreateGoal(GoalTypeInt);
                    break;

                case 2:
                    Console.WriteLine();
                    goalManager.ListGoalDetails();
                    break;

                case 3:
                    goalManager.SaveGoals();
                    break;

                case 4:
                    goalManager.LoadGoals();
                    break;
                
                case 5:
                    Console.WriteLine();
                    goalManager.RecordEvent();
                    break;
                












                case 6:
                
                    break;
                
                default:
                    Console.WriteLine("Ivalid option, please choose number between 1 and 6");
                    break;
                
            }
        }
    }
}
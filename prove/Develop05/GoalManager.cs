using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        //This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        DisplayPlayerInfo();
        Console.WriteLine();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("     1. Create New Goal");
        Console.WriteLine("     2. List Goals");
        Console.WriteLine("     3. Save Goals");
        Console.WriteLine("     4. Load Goals");
        Console.WriteLine("     5. Record Event");
        Console.WriteLine("     6. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the Menu: ");

    }

    public void DisplayPlayerInfo()
    {
        //Displays the players current score.
        Console.WriteLine($"Your current score is {_score}");        
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The type of Goals are: ");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Eternal GOal");
        Console.WriteLine("     3. Checklist Goal");
        Console.Write("What type of goal woould like to create? ");
    }
    public void ListGoalDetails()
    {   
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        int countEnd = _goals.Count;
        for (int i = 0; i < countEnd; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }


    public void CreateGoal(int goalTyptInt)
    {   

            Console.Write("what is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associate with this goal? ");
            string points = Console.ReadLine();
            int pointsInt = int.Parse(points);

        if (goalTyptInt == 1)
        {            
            SimpleGoal simpleGoal = new SimpleGoal(name, description, pointsInt, false);
            _goals.Add(simpleGoal);
        }
        else if (goalTyptInt == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, pointsInt);
            _goals.Add(eternalGoal);
        }
        else if (goalTyptInt == 3)
        {   
            Console.WriteLine("How many times does this goal need to be accomplished? ");
            string target = Console.ReadLine();
            int targetInt = int.Parse(target);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonus =  Console.ReadLine();
            int bonusInt =  int.Parse(bonus);

            CheckListGoal checkListGoal = new CheckListGoal(name, description, pointsInt, targetInt, bonusInt, 0);
            _goals.Add(checkListGoal);

        }
    }

    public void RecordEvent()
    {
        //displaying the options in the list
        Console.WriteLine("The goals are:");
        int countEnd = _goals.Count;
        for (int i = 0; i < countEnd; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
        
        //getting users reponse on the goal accomplished
        Console.WriteLine();
        Console.WriteLine("What goal did you accomplish");
        string GoalAccomplished = Console.ReadLine();
        int GoalAccomplishedInt = int.Parse(GoalAccomplished);

        Goal takingGol = _goals[GoalAccomplishedInt - 1];

        //getting the points from the object and adding it to the _score
        int pointRetreive = takingGol.RecordEvent();
        Console.WriteLine($"Congratulations! You got {pointRetreive} points!");        
        _score = _score + pointRetreive;

        Console.WriteLine();
        Console.WriteLine($"You now have {_score} points");

        

    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.WriteLine();
        Console.Write("preparing to save");
        ShowCountDown();
        Console.WriteLine();
        
        Console.WriteLine("Enter the name of the file youb want to save to without the filetype(txt,csv etc): ");
        string raw = Console.ReadLine();
        string filename = $"{raw}.txt";

        using (StreamWriter outPutFIle = new StreamWriter(filename))
        {  
            outPutFIle.WriteLine(_score); 
            foreach (Goal gol in _goals)
            {
                outPutFIle.WriteLine(gol.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine();
        Console.Clear();
        _goals.Clear();
        Console.Write("preparing to load");
        ShowCountDown();
        Console.WriteLine();

        Console.WriteLine("Enter the name of the file you wish to load from, without the filetype (txt, csv, etc.): ");
        string raw = Console.ReadLine();
        string filename = $"{raw}.txt";

        string[] lines = File.ReadAllLines(filename);

        // Reset _score before loading goals
        _score = 0;

        foreach (string line in lines)
        {
            // Ignore empty lines
            if (string.IsNullOrWhiteSpace(line))
                continue;

            // Parse _score
            if (int.TryParse(line, out int score))
            {
                _score = score;
                continue;
            }

            // Splitting on colon to get goal type and data
            string[] parts = line.Split(':');
            string goalType = parts[0];
            string data = parts[1];

            switch (goalType)
            {
                case "SimpleGoal":
                    string[] simpleGoalData = data.Split("~~");
                    string simpleName = simpleGoalData[0];
                    string simpleDescription = simpleGoalData[1];
                    ///int simplePoints = int.Parse(simpleGoalData[2]);

                    string equalSign = simpleGoalData[2];
                    string [] AfterEqualSign = equalSign.Split("==");
                    int simplePoints = int.Parse(AfterEqualSign[0]);
                    bool simpleIsComplete = bool.Parse(AfterEqualSign[1]);

                    //bool simpleIsComplete = bool.Parse(simpleGoalData[3]);
                    SimpleGoal simpleGoal = new SimpleGoal(simpleName, simpleDescription, simplePoints, simpleIsComplete);
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    string[] eternalGoalData = data.Split("~~");
                    string eternalName = eternalGoalData[0];
                    string eternalDescription = eternalGoalData[1];
                    int eternalPoints = int.Parse(eternalGoalData[2]);
                    EternalGoal eternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);
                    _goals.Add(eternalGoal);
                    break;
                case "CheckListGoal":
                    string[] checkListGoalData = data.Split("~~");
                    string checkListName = checkListGoalData[0];
                    string checkListDescription = checkListGoalData[1];
                    //int checkListPoints = int.Parse(checkListGoalData[2]);

                    //after || sign
                    string doubleBar = checkListGoalData[2];
                    string[] AfterdoubleBar = doubleBar.Split("||");
                    int checkListPoints = int.Parse(AfterdoubleBar[0]);

                    int target = int.Parse(AfterdoubleBar[1]);
                    int bonus = int.Parse(AfterdoubleBar[2]);
                    int amountCompleted = int.Parse(AfterdoubleBar[3]);
                    CheckListGoal checkListGoal = new CheckListGoal(checkListName, checkListDescription, checkListPoints, target, bonus, amountCompleted);
                    _goals.Add(checkListGoal);
                    break;
                default:
                    Console.WriteLine($"Unknown goal type: {goalType}");
                    break;
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
    public void ShowCountDown()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            //Console.Write("\b \b");
        }

    }    



    
}
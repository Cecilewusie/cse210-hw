public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

     public ListingActivity(string name, string description, string endingMessage) : base(name, description,endingMessage)
    {

    }

    public void Run()
    {
        GetRandomPrompt();
        List<string> usersList= GetLIstFromUser();
        _count = usersList.Count();
        Console.WriteLine($"You listed {_count} items.");

        Console.WriteLine();
        ShowSpinner(1000);
        DispalyEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(1000);
        Console.WriteLine();

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        int lCount = _prompts.Count();
        Random random = new Random();
        int randomInt = random.Next(0, lCount);
        string ranP = _prompts[randomInt];

        //displaying the prompt
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"-------- {ranP} ----------");
        Console.WriteLine("You may begin in..");
        ShowCountDown(1000);
    }

    private List<string> GetLIstFromUser()
    {   
        DateTime StartdateTime = DateTime.Now;
        DateTime endTime = StartdateTime.AddSeconds(_duration);

        List<string> ListFromUser = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write(">>");
            string inputsFromUser = Console.ReadLine();
            ListFromUser.Add(inputsFromUser);
        }

        return ListFromUser;
    }
}
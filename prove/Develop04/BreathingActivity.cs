public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, string endingMessage) : base(name, description,endingMessage)
    {

    }
    public void Run()
    {   
        Console.WriteLine("get ready");
        ShowSpinner(1000);

        //int duraCheck = 0;
        //this will be used to check how long the while loop should take or in other words, how long should the session be held
        //the parameter for the Addseconds was from th base member variable which has a datatype of protected
        DateTime beginDate = DateTime.Now;
        DateTime stopDate = beginDate.AddSeconds(_duration);

        while (DateTime.Now < stopDate)
        {   
            Console.WriteLine();
            List<string> Messages = new List<string>();

            Messages.Add("breath in...");
            Messages.Add("now breath out..");

            foreach (string m in Messages)
            {
                Console.WriteLine();
                Console.Write(m);
                ShowCountDown(1000);      
            }


        }
        Console.WriteLine();
        ShowSpinner(1000);
        DispalyEndingMessage();

    } 
}
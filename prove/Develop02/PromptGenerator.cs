public class PromtGenrator
{
    //the prompt generator will store a list of potential prompts that it can select from randomly when needed

    public List<string> _prompts = new List<string>();

    public string getRandomPrompt()
    {

        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What was the strongest emotion I felt today?");        
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("Anything funny you would like to share?");  

        int listCOunt = _prompts.Count();

        Random genRan = new Random();
        int gen = genRan.Next(0, listCOunt);
        string returnPrompt = _prompts[gen];
        return returnPrompt;                  
    }


}
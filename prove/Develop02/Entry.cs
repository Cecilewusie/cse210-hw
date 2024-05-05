public class Entry
{
    public List<string> _usersEntry;

    public string getRandomQuestion()
    {
  
            //Creating a list and adding the promp questions to the list
            List<string> promptQuestion = new List<string>();
            promptQuestion.Add("Who was the most interesting person I interacted with today?");
            promptQuestion.Add("What was the best part of my day?");
            promptQuestion.Add("How did I see the hand of the Lord in my life today?");
            promptQuestion.Add("What was the strongest emotion I felt today?");
            promptQuestion.Add("If I had one thing I could do over today, what would it be?");
            promptQuestion.Add("would you share a secrete today?");
            promptQuestion.Add("what are you still hoping to accomplish today");

            //Creating a new object for the random class
            Random randomQuestionGenerator = new Random();

            //counting the number of items in the promptQuestion list(python would have been len())
            int countedItems = promptQuestion.Count;

            //getting a random index from the list
            int index = randomQuestionGenerator.Next(countedItems);

            //calling the promptQuestion list and using the index to pull out the question and displaying them to the terminal window
            string randomQuestion = promptQuestion[index];
            //Console.WriteLine(randomQuestion);
            return randomQuestion;

            
    }

    public void displayUserEntry()
    {
        foreach (string u in _usersEntry)
        {
            Console.WriteLine(u);
        }
   
    }    


}
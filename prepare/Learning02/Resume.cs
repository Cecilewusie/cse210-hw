public class Resume
{
    //grouping the member variables
    public string _name;
    public List<JobHistory> _job = new List<JobHistory>();


    //This will display the Resume object when being called in another program
    public void DispalyResume()
    {   
        //printing the name once
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        //the for loop iterates through the _job list and stores them in the variable j, while accessing j,
        //we extract the Display method in JobHistory and prints them.        
        foreach (JobHistory j in _job)
        {   
            j.DisplayHistory();
        }
    }

}
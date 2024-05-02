
public class JobHistory
{
    //This class keeps track of the information of soon to be employee
    //grouping the member varaibles
    public string _company;
    public string _jobtitle;
    public int _startYear;
    public int _endYear;

    //creating a method or a function to display information of JobHistory class when called in another program
    public void DisplayHistory()
    {
        Console.WriteLine($"{_company}: {_jobtitle}, {_startYear}-{_endYear}");
    }
}
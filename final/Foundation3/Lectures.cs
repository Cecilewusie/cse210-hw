public class Lectures : Event
{
    private string _speakerName;
    private int _capacity;

    public Lectures(string title, string description, DateTime date, string time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()} \nSpeaker: {_speakerName} \nCapacity: {_capacity}";
    }


}
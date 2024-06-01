public class OutDoorGathering : Event
{
    private string _weatherStatement;

    public OutDoorGathering(string title, string description, DateTime date, string time, Address address, string weatherStatement) : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()} \nWeather Statement: {_weatherStatement}";
    }
}
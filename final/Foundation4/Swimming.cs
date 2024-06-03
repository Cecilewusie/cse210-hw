public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, int minutes, int numberOfLaps) : base(date, minutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000.00;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (GetMinute() / 60.0);

    }

    public override double GetPace()
    {
        return GetMinute() / GetDistance();
    }
     public override string GetSummary()
     {
        return $"{GetDateTime().ToString("dd MMM yyyy")} ({GetType().Name} - {GetMinute()} min): " +
               $"Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km, Laps: {_numberOfLaps}";
     }
}
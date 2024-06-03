public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minute, int distance) : base(date, minute)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinute()) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

}
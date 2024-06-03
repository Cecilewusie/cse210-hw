using System.Dynamic;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minute, double speed) : base(date,minute)
    {
        _speed = speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetMinute()) / 60;
    }
}
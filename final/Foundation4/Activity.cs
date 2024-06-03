public class Activity
{
    private DateTime _date;
    private int _minute;

    public Activity(DateTime date, int minute)
    {
        _date = date;
        _minute = minute;
    }

    public DateTime GetDateTime()
    {
        return _date;
    }

    public int GetMinute()
    {
        return _minute;
    }

    public virtual int GetLaps()
    {
        return 0;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} ({GetType().Name} - {_minute} min): " +
               $"Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";

    } 
}
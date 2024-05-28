public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //getters and setters for the member variables
    public string GetShortName()
    {
        return _shortName;
    }
    public void SetShortName()
    {
        _shortName = _shortName;
    }


    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string verif = "";
        if (IsComplete() == true)
        {
            string verify = $" [X] {_shortName}, ({_description})";
            verif = verify;
        }
        else
        {
            string verify = $" [ ] {_shortName}, ({_description})";
            verif = verify;
        }
        return verif;
    }

    public abstract string GetStringRepresentation();
    
}
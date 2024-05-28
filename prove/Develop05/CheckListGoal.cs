using System.Drawing;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        int point = 0;
        if (IsComplete())
        {
            int p = _points + _bonus;
            point = p;
        }
        else
        {
            int p = _points;
            point = p;
        }
        return point;
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {   
        string details = "";
        if (IsComplete())
        {
            string rep = $" [X] {_shortName}, ({_description}) -- currently completed: {_amountCompleted}/{_target}";
            details = rep;
        }
        else
        {
            string rep = $" [ ] {_shortName}, ({_description}) -- currently completed: {_amountCompleted}/{_target}";
            details = rep;            
        }
        return details;
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName}~~{_description}~~{_points}||{_target}||{_bonus}||{_amountCompleted}";
    }

}
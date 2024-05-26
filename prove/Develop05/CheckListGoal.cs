using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Property to get and set the amount completed
    public int AmountCompleted
    {
        get { return _amountCompleted; }
        set { _amountCompleted = value; }
    }

    // Property to get the bonus points
    public int Bonus
    {
        get { return _bonus; }
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return true;
        
    }

    public override string GetDetailsString()
    {
        if(IsComplete() && _target == _amountCompleted)
        {
            return $"[X] {ShortName} {Description} Completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {ShortName} {Description} Completed: {_amountCompleted}/{_target}";
        }

    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{ShortName}|{Description}|{Points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}

using System;

public class EnternalGoal : Goal
{



    public EnternalGoal(string name, string description, int points) : base (name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{ShortName}|{Description}|{Points}";
    }

}
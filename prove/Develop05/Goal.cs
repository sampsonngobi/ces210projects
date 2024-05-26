using System;

// The base class is made abstract. It is a generic class for derived goal classes
public abstract class Goal
{
    // Declare private variables 
    private string _shortName;
    private string _description;
    private int _points;

    // Create goal constructor to initialize the attributes 
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Getters and setters for each variable
    public string ShortName
    {
        get { return _shortName; }
        set { _shortName = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public int Points
    {
        get { return _points; }
        set { _points = value; }
    }

    // Create record object 
    public abstract void RecordEvent();

    // This function checks if the goal is completed 
    public abstract bool IsComplete();

    // This gets the details of the goal as a string 
    public virtual string GetDetailsString() 
    {
        if(IsComplete())
        {
        return $"[X] {_shortName} {_description}";
        }
        else
        {
            return $"[ ] {_shortName} {_description}";
        }
    }

    // Gets the string in a form savable to and loadable from a file 
    public abstract string GetStringRepresentation();
}

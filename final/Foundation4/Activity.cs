using System;

public abstract class Activity
{
    private string _activityDate;
    private double _activityDuration;

    public Activity(string activityDate, double activityDuration)
    {
        _activityDate = activityDate;
        _activityDuration = activityDuration;
    }

    public string GetActivityDate()
    {
        return _activityDate;
    }

    public double GetActivityDuration()
    {
        return _activityDuration;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();


    public virtual string GetSummary()
    {
        return $"{_activityDate} ({_activityDuration} min) - Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
  
    
}
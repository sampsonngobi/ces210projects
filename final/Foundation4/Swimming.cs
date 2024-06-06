using System;

public class Swimming : Activity
{
    private int _laps;
    private string _type = "Swimming";

    public Swimming(int laps, string activityDate, double activityDuration) : base(activityDate, activityDuration)

    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        
        return _laps  *  50  / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetActivityDuration()) * 60;
    }

    public override double GetPace()
    {
        return GetActivityDuration() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetActivityDate()} {_type} ({GetActivityDuration()} min) - Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
    
}
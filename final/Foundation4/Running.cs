using System;

public class Running : Activity
{
    private double _distance;
    private string _type = "Running";

    public Running(double distance, string activityDate, double activityDuration) : base(activityDate, activityDuration)

    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        
        return _distance;
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
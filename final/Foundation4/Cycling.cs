using System;

public class Cycling : Activity
{
    private int _speed;
    private string _type = "Cycling";

    public Cycling(int speed, string activityDate, double activityDuration) : base(activityDate, activityDuration)

    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        
        return _speed * GetActivityDuration();
    }

    public override double GetSpeed()
    {
        return _speed;
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
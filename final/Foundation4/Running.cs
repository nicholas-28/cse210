using System;
public class Running : Activity
{
    private double _distance; // in miles

    public Running(string date, double duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_duration / 60); // mph
    }

    public override double GetPace()
    {
        return _duration / _distance; // min/mile
    }
    public override string GetActivityType()
    {
        return "Running";
    }
}

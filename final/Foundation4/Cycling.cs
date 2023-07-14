using System;
public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(string date, double duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_duration / 60); // miles
    }

    public override double GetSpeed()
    {
        return _speed; // mph
    }

    public override double GetPace()
    {
        return 60 / _speed; // min/mile
    }

    public override string GetActivityType()
    {
        return "Cycling";
    }
}
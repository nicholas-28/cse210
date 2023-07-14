using System;
public class Swimming : Activity
{
    private int _laps; // number of laps

    public Swimming(string date, double duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1609.34; // convert meters to miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_duration / 60); // mph
    }

    public override double GetPace()
    {
        return _duration / GetDistance(); // min/mile
    }
    public override string GetActivityType()
    {
        return "Swimming";
    }

}

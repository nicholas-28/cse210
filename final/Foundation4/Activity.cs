using System;

public abstract class Activity
{
    protected string _date;
    protected double _duration; // in minutes

    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetActivityType()
    {
        return "Activity";
    }


    public virtual string GetSummary()
    {
        DateTime parsedDate = DateTime.Parse(_date);
        string formattedDate = parsedDate.ToString("dd MMM yyyy");

        string summary = $"{formattedDate} {GetActivityType()} ({_duration} min) - Distance: {GetDistance():F2} miles - Speed: {GetSpeed():F2} mph - Pace: {GetPace():F2} min/mile";
        return summary;
    }
}

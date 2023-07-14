using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>()
        {
            new Running("2023-07-15", 30, 3),
            new Cycling("2023-07-16", 30, 15),
            new Swimming("2023-07-17", 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{Name},{Description},{Points}";
    }

    public override void LoadGoal(string[] details)
    {
        Name = details[1];
        Description = details[2];
        Points = int.Parse(details[3]);
    }

    public override int RecordEvent()
    {
        return Points;
    }
}

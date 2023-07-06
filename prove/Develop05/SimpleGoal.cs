using System;
using System.Collections.Generic;
using System.IO;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsComplete = false;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{Name},{Description},{Points},{IsComplete}";
    }

    public override void LoadGoal(string[] details)
    {
        Name = details[1];
        Description = details[2];
        Points = int.Parse(details[3]);
        IsComplete = bool.Parse(details[4]);
    }

    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            return Points;
        }
        else
        {
            Console.WriteLine("Goal already completed");
            return 0;
        }
    }
}

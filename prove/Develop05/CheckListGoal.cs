using System;
using System.Collections.Generic;
using System.IO;

public class ChecklistGoal : Goal
{
    private int TimesToComplete { get; set; }
    private int TimesCompleted { get; set; }
    private int BonusPoints { get; set; }
    private bool ChecklistComplete { get; set; }

    public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusPoints)
    {
        Name = name;
        Description = description;
        Points = points;
        TimesToComplete = timesToComplete;
        BonusPoints = bonusPoints;
        TimesCompleted = 0;
        ChecklistComplete = false;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{Name},{Description},{Points},{BonusPoints},{TimesToComplete},{TimesCompleted},{ChecklistComplete}";
    }

    public override void LoadGoal(string[] details)
    {
        Name = details[1];
        Description = details[2];
        Points = int.Parse(details[3]);
        BonusPoints = int.Parse(details[4]);
        TimesToComplete = int.Parse(details[5]);
        TimesCompleted = int.Parse(details[6]);
        ChecklistComplete = bool.Parse(details[7]);
    }

    public override int RecordEvent()
    {
        if (!ChecklistComplete)
        {
            TimesCompleted++;
            if (TimesCompleted >= TimesToComplete)
            {
                TimesCompleted = 0;
                ChecklistComplete = true;
                return Points + BonusPoints;
            }
            else
            {
                return Points;
            }
        }
        else
        {
            Console.WriteLine("Checklist goal already completed.");
            return 0;
        }
    }

    public int GetTimesToComplete()
    {
        return TimesToComplete;
    }

    public int GetTimesCompleted()
    {
        return TimesCompleted;
    }

    public bool GetChecklistComplete()
    {
        return ChecklistComplete;
    }
}

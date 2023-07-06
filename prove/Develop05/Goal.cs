using System;
using System.Collections.Generic;
using System.IO;

public abstract class Goal
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Points { get; set; }
    protected bool IsComplete { get; set; }

    public string GetName()
    {
        return this.Name;
    }

    public void SetName(string value)
    {
        this.Name = value;
    }

    public string GetDescription()
    {
        return this.Description;
    }

    public void SetDescription(string value)
    {
        this.Description = value;
    }

    public int GetPoints()
    {
        return this.Points;
    }

    public void SetPoints(int value)
    {
        this.Points = value;
    }

    public bool GetIsComplete()
    {
        return this.IsComplete;
    }

    public void SetIsComplete(bool value)
    {
        this.IsComplete = value;
    }
    public abstract string GetStringRepresentation();
    public abstract void LoadGoal(string[] details);
    public abstract int RecordEvent();
}

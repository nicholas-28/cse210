using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private const string GoalSavePath = "goaldata.txt";
    private List<Goal> goals;
    private int points;

    public GoalManager()
    {
        goals = new List<Goal>();
        points = 0;
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"You have {points} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        string goalType = Console.ReadLine();

        Console.WriteLine("What is the name of your goal?");
        string goalName = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        string goalDescription = Console.ReadLine();

        Console.WriteLine("What is amount of points associated with this goal?");
        int goalPoints = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
                break;
            case "2":
                goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
                break;
            case "3":
                Console.WriteLine("How many times this goal need to be accomplished for a bonus?");
                int timesToComplete = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the bonus for accomplishing it that many times?");
                int bonusPoints = int.Parse(Console.ReadLine());

                goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, timesToComplete, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }

    public void ListGoals()
{
    Console.WriteLine("The goals are:");
    for (int i = 0; i < goals.Count; i++)
    {
        var goal = goals[i];
        if (goal is ChecklistGoal checklistGoal)
        {
            Console.WriteLine($"{i + 1}. {(checklistGoal.GetChecklistComplete() ? "[X]" : "[ ]")} {checklistGoal.GetName()} ({checklistGoal.GetDescription()}) — Currently completed: {checklistGoal.GetTimesCompleted()}/{checklistGoal.GetTimesToComplete()}");
        }
        else if(goal is EternalGoal)
        {
            Console.WriteLine($"{i + 1}. [ ] {goal.GetName()} ({goal.GetDescription()})");
        }
        else
        {
            Console.WriteLine($"{i + 1}. {(goal.GetIsComplete() ? "[X]" : "[ ]")} {goal.GetName()} ({goal.GetDescription()})");
        }
    }
}

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();
        using (var writer = new StreamWriter(filename))
        {
            writer.WriteLine(points);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            using (var reader = new StreamReader(filename))
            {
                points = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] goalData = line.Split(',');

                    Goal goal;
                    switch (goalData[0])
                    {
                        case "SimpleGoal":
                            goal = new SimpleGoal("", "", 0);
                            goal.LoadGoal(goalData);
                            goals.Add(goal);
                            break;
                        case "EternalGoal":
                            goal = new EternalGoal("", "", 0);
                            goal.LoadGoal(goalData);
                            goals.Add(goal);
                            break;
                        case "ChecklistGoal":
                            goal = new ChecklistGoal("", "", 0, 0, 0);
                            goal.LoadGoal(goalData);
                            goals.Add(goal);
                            break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine($"File {filename} does not exist.");
        }
    }

    public void RecordEvent()
    {
    Console.WriteLine("The goals are:");
    for (int i = 0; i < goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
    }
    Console.WriteLine("Which goal did you accomplish?");
    int goalNumber = int.Parse(Console.ReadLine()) - 1;
    if (goalNumber >= 0 && goalNumber < goals.Count)
    {
        int previousPoints = points;
        points += goals[goalNumber].RecordEvent();
        int earnedPoints = points - previousPoints;
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        Console.WriteLine($"You now have {points} points.");
    }
    else
    {
        Console.WriteLine("Invalid goal number.");
    }
    }

}

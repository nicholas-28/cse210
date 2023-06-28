using System;
using System.Threading;

// Abstract class that defines a blueprint for an activity
abstract class Activity
{
    // Each activity must have a name
    public abstract string Name { get; }

    // Each activity must have a method to start it
    public abstract void Start();

    // Each activity must have a method to run it for a certain duration
    public abstract void Run(int duration);

    // Method to get the duration of the activity from the user
    public int GetActivityDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        return int.Parse(Console.ReadLine());
    }

    // Method to display a spinner for a given number of seconds
    public void ShowSpinner(int seconds)
    {
        List<string> symbols = new List<string>() { "/", "-", "\\", "|" };
        int index = 0;

        for (int i = 0; i < seconds; i++)
        {
            Console.Write(symbols[index]);
            Thread.Sleep(500);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            index = (index + 1) % symbols.Count;
        }
        Console.Write(" ");
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }

    // Method to display a countdown for a given number of seconds
    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            if (i > 0)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
                Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
            }
            else
            {
                Console.Write("  ");
            }
        }
    Console.Write("\n");
    }
}

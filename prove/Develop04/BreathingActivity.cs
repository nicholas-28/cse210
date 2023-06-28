using System;
using System.Threading;

// BreathingActivity class which is a type of Activity
class BreathingActivity : Activity
{
    // The name of the activity
    public override string Name => "Breathing Activity";

    // Method to start the activity
    public override void Start()
    {
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
    }

    // Method to run the activity for a certain duration
    public override void Run(int duration)
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("\n");
        for (int i = 0; i < duration; i += 10)
        {

            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.Write("Breathe out...");
            ShowCountdown(4);
            Console.WriteLine(" ");

            if (i + 10 < duration)
                Thread.Sleep(1000);
        }

        Console.WriteLine("\nWell done!!\n");
        ShowSpinner(5);
    }
}

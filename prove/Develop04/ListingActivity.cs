using System;
using System.Threading;

// ListingActivity class which is a type of Activity
class ListingActivity : Activity
{
    // Static list of listing prompts
    private static readonly List<string> ListingPrompts = new List<string> 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // The name of the activity
    public override string Name => "Listing Activity";

    // Method to start the activity
    public override void Start()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
    }

    // Method to run the activity for a certain duration
    public override void Run(int duration)
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine(" ");
        Random random = new Random();
        string prompt = ListingPrompts[random.Next(ListingPrompts.Count)];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        var startTime = DateTime.Now;
        int count = 0;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");

        Console.WriteLine("\nWell done!!\n");
        ShowSpinner(5);
    }
}

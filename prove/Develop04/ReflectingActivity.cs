using System;
using System.Threading;

// ReflectingActivity class which is a type of Activity
class ReflectingActivity : Activity
{
    // Static list of reflection prompts
    private static readonly List<string> ReflectingPrompts = new List<string> 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // Static list of reflection questions
    private static readonly List<string> ReflectingQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // The name of the activity
    public override string Name => "Reflecting Activity";

    // Method to start the activity
    public override void Start()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
    }

    // Method to run the activity for a certain duration
    public override void Run(int duration)
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine(" ");

        Random random = new Random();
        string prompt = ReflectingPrompts[random.Next(ReflectingPrompts.Count)];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("\n");
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine("\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();
        var startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("> ");
            string question = ReflectingQuestions[random.Next(ReflectingQuestions.Count)];
            Console.Write(question);
            ShowSpinner(15);
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine("\nWell done!!\n");
        ShowSpinner(5);
    }
}

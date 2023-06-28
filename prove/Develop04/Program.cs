using System;
using System.Collections.Generic;
using System.Threading;

// The main class that is responsible for handling the main operations of the program
class Program
{
    // Entry point of the program
    static void Main(string[] args)
    {
        // Defining menu options
        string menu = "Menu Options:\n" +
            "  1. Start breathing activity\n" +
            "  2. Start reflecting activity\n" +
            "  3. Start listing activity\n" +
            "  4. Quit\n\n" +
            "Select a choice from the menu: ";

        // Looping until user quits the program
        while (true)
        {
            Console.Clear();
            Console.Write(menu);
            string input = Console.ReadLine();

            if (input == "4")
                break;

            Console.Clear();
            switch (input)
            {
                case "1":
                    RunActivity(new BreathingActivity());
                    break;
                case "2":
                    RunActivity(new ReflectingActivity());
                    break;
                case "3":
                    RunActivity(new ListingActivity());
                    break;
            }
        }
    }

    // Method to start an activity and provide user interaction
    static void RunActivity(Activity activity)
    {
        Console.WriteLine($"Welcome to the {activity.Name}.\n");
        activity.Start();
        int duration = activity.GetActivityDuration();
        Console.Clear();

        activity.Run(duration);
        Console.WriteLine($"You have completed another {duration} seconds of the {activity.Name}.");
        Thread.Sleep(2000);

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}
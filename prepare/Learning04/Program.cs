using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asg1 = new Assignment("Nikolai Cherenkov", "Music Production");
        Console.WriteLine(asg1.GetSummary());
    }
}
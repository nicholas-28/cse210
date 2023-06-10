using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asg1 = new Assignment("Nikolai Cherenkov", "Music Production");
        Console.WriteLine(asg1.GetSummary());

        MathAssignment asg2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-9");
        Console.WriteLine(asg2.GetSummary());
        Console.WriteLine(asg2.GetHomeworkList());

        WritingAssignment asg3 = new WritingAssignment("Mary Waters", "European History","The Causes of World War II");
        Console.WriteLine(asg3.GetSummary());
        Console.WriteLine(asg3.GetWritingInformation());
    }
}
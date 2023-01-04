using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int gradePerc = int.Parse(input);

        string grade = "";
        if (gradePerc >= 90)
        {
            grade = "A";
        }
        else if (gradePerc >= 80)
        {
            grade = "B";
        }
        else if (gradePerc >= 70)
        {
            grade = "C";
        }
        else if (gradePerc >= 60)
        {
            grade = "D";
        }
        else 
        {
            grade = "F";
        }

        Console.WriteLine(grade);

        if (gradePerc >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class");
        }
        else 
        {
            Console.WriteLine("You didn't pass the class. You can do better.");
        }
    }
}
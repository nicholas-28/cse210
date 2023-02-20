using System;
using System.IO;
using System.Text;
class Program
{
    static void Main(string[] args)
    {   
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine("Welcome to the Journal Program!");

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine()); 

            if (choice == 1)
            {
                PromptGenerator prompt = new PromptGenerator();
                prompt.DisplayPrompt();
                Console.Write("> ");
                string answer = Console.ReadLine();
            }



        }
    }
}
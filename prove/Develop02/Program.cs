using System;
using System.IO;
using System.Text;
class Program
{
    static void Main(string[] args)
    {   Journal journal = new Journal();

        
        Console.WriteLine("Welcome to the Journal Program!");

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            int input = int.Parse(Console.ReadLine()); 

            switch (input)
            {
                case 1:
                    //WriteEntry
                    journal.WriteEntry();

                    break;
                
                case 2:
                    //DisplayEntries
                    journal.DisplayEntries();
                    break;

                case 3:
                    //LoadEntries
                    break;

                case 4:
                    //SaveEntries
                    break;

                case 5:

                    quit = true;
                    break;

                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;


            }



        }
    }
}
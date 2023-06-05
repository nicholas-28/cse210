using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Word word = new Word("test");
        // System.Console.WriteLine(word.GetRenderedText());
        // word.Hide();
        // System.Console.WriteLine(word.GetRenderedText());
        // System.Console.WriteLine(word.IsHidden());

        // Create a reference and scripture text
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        // Create a scripture object
        Scripture scripture = new Scripture(reference, scriptureText);
        // Display the reference of the scripture
        Console.WriteLine("Scripture Reference: " + reference.GetFormattedReference());

        // Loop until all words in the scripture are hidden or user quits
        while (!scripture.IsCompletelyHidden())
        {
            // Clear the console and display the scripture
            scripture.ClearConsoleAndDisplay();

            // Prompt the user to hide a random word or quit
            Console.WriteLine("\nPress Enter to hide a random word or type 'quit' to exit:");
            string input = Console.ReadLine();

            // Check if user wants to quit
            if(input == "quit")
            {
                break;
            }

            // Hide three random words in the scripture
            scripture.HideRandomWords(3);

            // Clear the console and display the updated scripture
            scripture.ClearConsoleAndDisplay();
        }
        // Display a message when all words are hidden or program is ended
        Console.WriteLine("\nAll words have been hidden. Program ended.");
    }
}
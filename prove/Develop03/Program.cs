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

        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Scripture scripture = new Scripture(reference, scriptureText);
        Console.WriteLine("Scripture Reference: " + reference.GetFormattedReference());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to hide a random word or type 'quit' to exit:");
            string input = Console.ReadLine();
            
            if(input == "quit")
            {
                break;
            }
            scripture.HideRandomWord();
            scripture.ClearConsoleAndDisplay();
        }
        Console.WriteLine("\nAll words have been hidden. Program ended.");
    }
}
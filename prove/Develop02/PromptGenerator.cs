using System;
using System.IO;
using System.Text;
public class PromptGenerator
{
    private int lastIndex = -1;
    public List<string> prompts = new List<string>()
    {
        "What is your favorite part of the day?",
        "What do you remember about this day the most?",
        "Who or what inspired you today?",
        "What is the most difficult thing you faced today?", 
        "What would you like to do more often?"
    };



    public int LastIndexDisplayed => lastIndex;
    public void DisplayPrompt()
    {
        var random = new Random();
        int index = random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);
        lastIndex = index;
    }


}
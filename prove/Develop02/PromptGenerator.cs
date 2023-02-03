using System;
using System.IO;
using System.Text;
public class PromptGenerator
{
    public void DisplayPrompt()
    {
        var random = new Random();
        var list = new List<string>{ "What is your favorite part of the day?","What do you remember about this day the most?","Who or what inspired you today?","What is the most difficult thing you faced today?", "What would you like to do more often?"};
        int index = random.Next(list.Count);
        Console.WriteLine(list[index]);
    }


}
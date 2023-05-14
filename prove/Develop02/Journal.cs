using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class Journal
{   PromptGenerator promptGenerator = new PromptGenerator();

    

    public List<Entry> Entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }
    public void WriteEntry()
    {
        promptGenerator.DisplayPrompt();
        int lastIndex = promptGenerator.LastIndexDisplayed;
        Console.Write("> ");
        string prompt = promptGenerator.prompts[lastIndex];
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();
        AddEntry(new Entry(prompt, response, date));
        Console.WriteLine("Entry saved!");

    }
    
    public void DisplayEntries()
    {
        foreach( Entry entry in Entries)
        entry.Display();
    }
}
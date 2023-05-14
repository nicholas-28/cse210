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
        if(Entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
        }
        else
        {
            foreach( Entry entry in Entries)
            entry.Display();
        }

    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(fileName))
        {
            foreach(Entry entry in Entries)
            {
                sw.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt} {entry._response}");
            }
        }
    Console.WriteLine($"Journal saved to file named: {fileName}");

    }

    publ
}
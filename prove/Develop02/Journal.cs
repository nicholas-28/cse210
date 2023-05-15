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
                sw.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._response}");
            }
        }
    Console.WriteLine($"Journal saved to file named: {fileName}");

    }

    public void LoadFromFile(){

        Console.WriteLine("What is a filename?");
        string fileName = Console.ReadLine();

        List<Entry> entries = new List<Entry>();

        using (StreamReader sr = new StreamReader(fileName))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                string[] parts = line.Split(new string[] { "~~" }, StringSplitOptions.None);
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                Entry entry = new Entry(prompt, response, date);
                entries.Add(entry);

                Console.WriteLine($"Date: {date} - Prompt: {prompt} - Response: {response}");
            }
        }
        Entries = entries;

        Console.WriteLine($"Journal loaded from file named: {fileName}");
    }
}
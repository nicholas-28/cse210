using System;
using System.IO;
using System.Text;

public class Journal
{
    public string JournalFile = "";


    public void CreateJournalFile()
    {
        if (!File.Exists(JournalFile))
        {
            File.CreateText(JournalFile); 
        }
    }

    public void DisplayJournalContents()
    {
        string journalText = File.ReadAllText(JournalFile);
        Console.WriteLine(journalText);
    }

    public void ClearFile()
    {
        File.WriteAllText(JournalFile, "");
    }

    public void AddEntry()
    {
        string newLine = Console.ReadLine();
        File.AppendAllText(JournalFile, newLine); 
    }
    
}
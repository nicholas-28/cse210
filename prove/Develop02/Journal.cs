using System;
using System.IO;
using System.Text;

public class Journal
{
    public string JournalFile = "";
    public void Run()
    {
        CreateJournalFile();
        DisplayJournalContents();
        ClearFile();

    }

    private void CreateJournalFile()
    {
        if (!File.Exists(JournalFile))
        {
            File.CreateText(JournalFile); 
        }
    }

    private void DisplayJournalContents()
    {
        string journalText = File.ReadAllText(JournalFile);
        Console.WriteLine(journalText);
    }

    private void ClearFile()
    {
        File.WriteAllText(JournalFile, "");
    }

    private void AddEntry()
    {
        string newLine = Console.ReadLine();
        File.AppendAllText(JournalFile, newLine); 
    }
    
}
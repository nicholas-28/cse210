using System;
using System.Collections.Generic;
// Represents a scripture with its reference and text

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = CreateWordList(text);
    }
  // Creates a list of Word objects from the scripture text
    private List<Word> CreateWordList(string text)
    {
        string[] words = text.Split(' ');
        List<Word> wordList = new List<Word>();

        foreach (string word in words)
        {
            wordList.Add(new Word(word));
        } 

        return wordList;
    }
    
   // Hides a specified number of random words in the scripture
    public void HideRandomWords(int count)
    {
        // Random random = new Random();
        // int index = random.Next(_words.Count);
        // _words[index].Hide();
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            List<Word> hiddenWords = _words.FindAll(word => word.IsHidden());

            if (hiddenWords.Count == _words.Count)
            {
                break;
            }

            Word randomWord;

            do
            {
                randomWord = _words[random.Next(_words.Count)];
            } while (randomWord.IsHidden());

            randomWord.Hide();
        }
    }
// Clears the console screen and displays the scripture
    public void ClearConsoleAndDisplay()
    {
        Console.Clear();
        Console.WriteLine(GetScriptureText());
    }
 // Gets the full text of the scripture, including the reference and the rendered words
    private string GetScriptureText()
    {
        string scriptureText = _reference.GetFormattedReference() + " ";
        foreach (Word word in _words)
        {
            scriptureText += word.GetRenderedText() + " ";
        }
        return scriptureText.Trim();
    }
    // Checks if all the words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }



}
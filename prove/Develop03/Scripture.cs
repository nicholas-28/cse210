using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = CreateWordList(text);
    }

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
    

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(_words.Count);
        _words[index].Hide();
    }

    public void ClearConsoleAndDisplay()
    {
        Console.Clear();
    }

    private string GetScriptureText()
    {
        string scriptureText = _reference.GetFormattedReference() + " ";
        foreach (Word word in _words)
        {
            scriptureText += word.GetRenderedText() + " ";
        }
        return scriptureText.Trim();
    }
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
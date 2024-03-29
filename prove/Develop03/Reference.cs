using System;
using System.Collections.Generic;
// Represents the reference of a scripture (e.g., "John 3:16")
public class Reference 
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _secondVerse;

    public Reference(string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
    }
    public Reference(string book, int chapter, int firstVerse, int secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _secondVerse = secondVerse;
    }
    // Gets the formatted reference string
    public string GetFormattedReference()
    {
        if (_secondVerse == 0)
        {
            return $"{_book} {_chapter}:{_firstVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_firstVerse}-{_secondVerse}";
        }
    }
}
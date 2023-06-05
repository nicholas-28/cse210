using System;
using System.Collections.Generic;
// Represents a single word in the scripture
public class Word 
{
    private string _word;
    private bool _hidden;

    public Word(string word){
        _word = word;
        _hidden = false;
    }
    // Hides the word
    public void Hide()
    {
        _hidden = true;
    }

    // Shows the word
    public void Show()
    {
        _hidden = false;
    }
    // Checks if the word is hidden
    public bool IsHidden()
    {
        return _hidden;
    }
    // Returns the rendered text of the word (either the word itself or underscore characters if hidden)
    public string GetRenderedText()
    {
        if (_hidden)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }

}



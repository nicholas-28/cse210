using System;
using System.Collections.Generic;
public class Comment
{
    protected string _commenterName;
    protected string _text;

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetText()
    {
        return _text;
    }
}
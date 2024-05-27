using System;

public class Comment
{
     string _commenter;
     string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }

    public string GetCommenter()
    {
        return _commenter;
    }

    public string GetText()
    {
        return _text;
    }
}

using System;

public class Comment
{
    private string _nameCom;
    private string _textCom;

    public Comment(string name, string text)
    {
        _nameCom = name;
        _textCom = text;
    }
    public string ComDisplay()
    {
        string display = $"{_nameCom} says:  \"{_textCom}\"";
        return display;
    }

}
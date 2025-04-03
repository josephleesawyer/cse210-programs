using System;

public class Assignment
{
    private string _studName;
    private string _topic;
    public Assignment(string stud, string top)
    {
        _studName = stud;
        _topic = top;
    }
    public string StudAndTopDisplay()
    {
        string display = $"{_studName} | {_topic}";
        return display;
    }
    public string StudName()
    {
        return _studName;
    }
}
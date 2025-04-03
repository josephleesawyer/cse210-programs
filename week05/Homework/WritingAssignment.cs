using System;

public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string stud, string top, string title) : base(stud, top)
    {
        _title = title;
    }
    public string EssayDisplay()
    {
        string display = $"\"{_title}\"  by {StudName()}";
        return display;
    }
}

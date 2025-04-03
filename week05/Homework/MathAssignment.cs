using System;

public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _probs;
    public MathAssignment(string stud, string top, string textBookSec, string probset) : base(stud, top)
    {
        _textBookSection = textBookSec;
        _probs = probset;
    }
    public string HomeworkDisplay()
    {
        string display = $"{_textBookSection},  {_probs}";
        return display;
    }
}

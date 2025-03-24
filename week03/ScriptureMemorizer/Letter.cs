using System;

public class Letter
{
    private string _letter;
    private bool _showing = true;

    public string LetterDisplay()
    {
        string display = _letter;
        if (!_showing)
        {
            display = "_";
        }
        return display;
    }
    public Letter(string letter)
    {
        _letter = letter;
    }
    public void Hide()
    {
        _showing = false;
    }
    public bool Showing()
    {
        return _showing;
    }

}
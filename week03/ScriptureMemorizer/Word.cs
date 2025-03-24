using System;

public class Word
{
    private string _wordText;
    private List<Letter> _lettersList = new List<Letter>();
    // Get Display:
    public string WordDisplay()
    {
        string display = "";
        foreach (Letter letter in _lettersList)
        {
            display += letter.LetterDisplay();
        }
        return display;
    }
    // Constructor:
    public Word(string word)
    {
        _wordText = word;
        foreach (char letter in _wordText)
        {
            _lettersList.Add(new Letter(letter.ToString()));
        }
    }
    // Hide entire word (self):
    public void HideWord()
    {
        foreach (Letter letter in _lettersList)
        {
            letter.Hide();
        }
    }
    public void HideRandomLetter()
    {
        Random rng = new();
        int i;
        do
        {
            i = rng.Next(_lettersList.Count);
        } while (!_lettersList[i].Showing());
        _lettersList[i].Hide();
    }
    // Is this Word Showing at all?
    public bool Showing()
    {
        int showingLetters = 0;
        foreach (Letter letter in _lettersList)
        {
            if (letter.Showing())
            showingLetters ++;
        }
        if (showingLetters > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
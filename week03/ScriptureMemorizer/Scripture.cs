using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _wordList = new();
    private string _displayCode = "";

    // Constructor:
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // Initialize Values for ALCHEMY
        string currentWordConstruction = "";
        // bool wasPunct = false;
        bool wasLett = false;
        int wordIndex = 0;
        // Begin Alchemy Circle
        foreach (char character in text)
        {   
            //Check to see if character is Punctuation
            string charString = character.ToString();
            bool isPunctuation = false;
            string punctuationMarks = ",./?;:[]{}`~1234567890-=!@#$%^&*()_+ ";
            foreach (char c in punctuationMarks)
            {
                if (character == c || character == '"')
                {
                    isPunctuation = true;
                }
            }
            // Codify Punctuation and Commit Finished Words:
            if (isPunctuation)
            {
                if (wasLett)
                {
                    // Convert finished word into Word class and add to Scripture's List
                    _wordList.Add(new Word(currentWordConstruction));
                    // Reset Word construction to 0:
                    currentWordConstruction = "";
                    // Add Word Code to Display Code
                    _displayCode += "w";
                    _displayCode += wordIndex.ToString();
                    _displayCode += "d";
                    wordIndex ++;
                }
                _displayCode += character.ToString();
                wasLett = false;
            }
            // Codify and Reconstruct Words:
            else
            {
                currentWordConstruction += character.ToString();
                wasLett = true;
            }
        }
    }
    // Get Display:
    public string ScriptureDisplay()
    {   
        string display = $"{_reference.RefDisplay()}\r\n";
        // Decode
        bool wordIndexIncoming = false;
        string currentWCConstruction = "";
        foreach (char code in _displayCode)
        {
            if (code == 'd')
            {
                display += _wordList[int.Parse(currentWCConstruction)].WordDisplay();
                currentWCConstruction = "";
                wordIndexIncoming = false;
            }
            else if (wordIndexIncoming)
            {
                currentWCConstruction += code.ToString();
            }
            else if (code == 'w')
            {
                wordIndexIncoming = true;
            }
            else if (code == '~')
            {
                display += "\r\n";
            }
            else
            {
                display += code.ToString();
            }
        }
        return display;
    }
    // Is it all gone?:
    public bool IsAllHidden()
    {
        int showingWords = 0;
        foreach (Word word in _wordList)
        {
            if (word.Showing())
            {
                showingWords ++;
            }
        }
        if (showingWords == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    // Hide a Random Word
    public void HideRandomWord()
    {
        if (!IsAllHidden())
        {
            Random rng = new();
            int i;
            do
            {
                i = rng.Next(_wordList.Count);
            } while (!_wordList[i].Showing());
            _wordList[i].HideWord();
        }
    }
    // Hide a Random Letter Among the Words:
    public void HideRandomLetter()
    {
        if (!IsAllHidden())
        {
            Random rng = new();
            int i;
            do
            {
                i = rng.Next(_wordList.Count);
            } while (!_wordList[i].Showing());
            _wordList[i].HideRandomLetter();
        }
    }
}
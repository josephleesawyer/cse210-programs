using System;

public class Reference
{
    private string _book;
    private int _chapterOrSection;
    private int _verseStart;
    private int _verseEnd;

    public string RefDisplay()
    {
        string ference = $"{_book} {_chapterOrSection}:{_verseStart}";
        if (_verseStart != _verseEnd)
        {
            ference += $"-{_verseEnd}";
        }
        return ference;
    }
    public Reference(string book)
    {
        _book = book;
        _chapterOrSection = 1;
        _verseStart = 1;
        _verseEnd = 1;
    }
    public Reference(string book, int chap, int start)
    {
        _book = book;
        _chapterOrSection = chap;
        _verseStart = start;
        _verseEnd = start;
    }
    public Reference(string book, int chap, int start, int end)
    {
        _book = book;
        _chapterOrSection = chap;
        _verseStart = start;
        _verseEnd = end;
    }

}
using System;

public class Entry
{
    private string _contents;
    private string _prompt;
    private string _date;
    private string _rating;

    //Constructor
    public Entry()
    {
        PromptGenerator proGen = new();
        _prompt = proGen.GetRandomPrompt();
        Console.WriteLine(_prompt);
        _contents = Console.ReadLine(); 
        Console.WriteLine("How do I feel on a scale of 1-10?");
        _rating = Console.ReadLine();         
        Console.WriteLine("Date: (mm/dd/yyyy)");
        _date = Console.ReadLine(); 
    }
    public Entry(string loadCode)
    {
        string[] codeParts = loadCode.Split("~~~");

        _date = codeParts[0];
        _prompt = codeParts[1];
        _contents = codeParts[2];
        _rating = codeParts[3];
    }
    public Entry(string date, string rating, string prompt, string contents)
    {
        _prompt = prompt;
        _contents = contents; 
        _rating = rating;
        _date = date; 
    }
    public string EntryDisplay()
    {
        string display = $"{_date}\r\n{_prompt}\r\n{_contents}\r\n   feeling: {_rating} / 10";
        return display;
    }
    
    public string SaveCode()
    {
        string saveCode = $"{_date}~~~{_prompt}~~~{_contents}~~~{_rating}";
        return saveCode;
    }
    

}
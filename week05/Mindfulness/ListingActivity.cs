using System;
using System.Diagnostics.Contracts;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    
    public ListingActivity(string actName, string actdesc, List<string> prompts) : base(actName, actdesc)
    {
       _prompts = prompts;
    }
    public override void Run()
    {
        SetupActivity();
        Console.WriteLine($"\r\n{GetRandomPrompt()}\r\n");
        Console.Write($"Session starting in: ");
        DisplayCountDownTimer(9);
        Console.Write($"\r\nType an answer to the prompt and then hit enter. \r\nList as many answers as you can think of. Take your time. \r\n");
        DateTime endTime = GetEndTime();
        do 
        {
            string answer;
            answer = Console.ReadLine();
            if (answer != "")
            {
                _count++;
            }
        } while (DateTime.Now < endTime);
        Console.WriteLine($"\r\nEnd of session. You entered {_count} entries. ");
        WrapUpActivity();
    }
    public string GetRandomPrompt()
    {
        Random rnd = new();
        string promptChosen = _prompts[rnd.Next(_prompts.Count)];
        return promptChosen;
    }



}
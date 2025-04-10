using System;

public abstract class Activity
{
    private string _actName;
    private string _actDescription;
    private int _durationMin;
    public Activity(string actName, string actdesc)
    {
        _actName = actName;
        _actDescription = actdesc;
    }
    public void SetupActivity()
    {
        Console.WriteLine($"\r\n\r\nStarting {_actName} Activity. \r\n{_actDescription}");
        string answer = "";
        do 
        {
            Console.Write($"\r\nHow may minutes would you like to do the activity?\r\n   >");
            answer = Console.ReadLine();
        } while (!int.TryParse(answer, out _durationMin));
        Console.WriteLine($"\r\nPlease take some slow breaths to prepare yourself for the activity... ");
        DisplayCountDownTimer(7);
    }


    public void WrapUpActivity()
    {
        Console.WriteLine($"\r\nAll done.");
        Console.WriteLine($"\r\nWell done! You have completed the {_actName} meditation.");
        Console.WriteLine($"\r\nDon't worry about doing it perfectly-- what's important is that you did it.");
        Console.WriteLine($"\r\nYou've spent {_durationMin} minutes meditating! Well done! You are well on your way to mindfulness. ");
        Console.Write($"\r\nEnding activity in: ");
        DisplayCountDownTimer(9);
    }


    public DateTime GetEndTime()
    {
        DateTime endTime = DateTime.Now.AddMinutes(_durationMin);
        return endTime;
    }

    public void DisplayCountDownTimer(int secsTotal)
    {
        for (int seconds = secsTotal; seconds > 0; seconds--)
        {
            Console.Write($"{seconds}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public string GetName()
    {
        return _actName;
    }
    public abstract void Run();
}
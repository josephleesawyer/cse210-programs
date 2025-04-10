using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string actName, string actdesc) : base(actName, actdesc)
    {
       int nada = 0;
       if (nada == 1)
       {
        Console.WriteLine("What?");
       } 
    }

    public override void Run()
    {
        SetupActivity();
        Console.WriteLine($"\r\nExhale completely, then Press ENTER when Ready\r\n");
        Console.Read();
        DateTime endTime = GetEndTime();
        bool haleFlip = true;
        int breathCount = 3;
        do 
        {
            Hale(haleFlip, breathCount);
            if (!haleFlip && breathCount < 8)
                breathCount++;
            haleFlip = !haleFlip;
        } while (DateTime.Now < endTime);
        WrapUpActivity();
    }
    public void Hale(bool inBool, int secondsOfHale)
    {
        string hale;
        if (inBool)
        {
            hale = "|";
        }
        else
        {
            hale = "\b \b";
        }

        for (int sec = 0; sec < secondsOfHale; sec++)
        {
            for (float parSec = 0; parSec < 800;)
            {
                int par = 1000/(secondsOfHale-sec);
                Thread.Sleep(par);
                Console.Write(hale);
                parSec += par;
            }
        }
    }
}
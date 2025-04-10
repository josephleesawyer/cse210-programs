using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        List<string> aniList = new();
        aniList.Add(" __ ");
        aniList.Add("<_  ");
        aniList.Add("<*  ");
        aniList.Add(" ** ");
        aniList.Add("  *>");
        aniList.Add("  _>");
        
        for (int seconds = 10; seconds > 0; seconds--)
        {
            foreach (string asciiFrame in aniList)
            {
                // int len = asciiFrame.Count();
                Console.Write($"\b\b\b\b{asciiFrame}");
                Thread.Sleep(250);
                // foreach (char letter in asciiFrame)
                // {
                //     Console.Write("\b");
                // }
                // foreach (char letter in asciiFrame)
                // {
                //     Console.Write(" ");
                // }
                // foreach (char letter in asciiFrame)
                // {
                //     Console.Write("\b");
                // }
                Console.Write("\b\b\b\b    ");

            }
        }

    }
}
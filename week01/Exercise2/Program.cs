using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What... is your Grade (percentage %)? ");
        int gradeNum = int.Parse(Console.ReadLine());
        string gradeLetter;
        if (gradeNum >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNum >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNum >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNum >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
        
        string passFailPhrase = "You failed. You can try again next year, bud. ";

        if (gradeNum >= 70)
        {
            passFailPhrase = "You passed! Congrats, kiddo!";
        }



        Console.WriteLine($"Your Grade is: {gradeLetter}  {passFailPhrase}");
    }
}
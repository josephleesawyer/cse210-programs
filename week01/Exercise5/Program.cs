using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(),SquareNumber(PromptUserNumber()));
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Enter Name > ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favourite number? > ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }
    static double SquareNumber(int num)
    {
        int sqr = num*num;
        return sqr;
    }
    static void DisplayResult(string nombre, double esquina)
    {
        Console.WriteLine($"{nombre}, your favourite number's square is {esquina}! ");
    }
}
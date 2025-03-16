using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string _firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string _lastName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {_lastName}, {_firstName} {_lastName}.");
        Console.WriteLine();
        Console.WriteLine(". . . ");
        Console.WriteLine();
        Console.Write("What... is your quest? ");
        string _quest = Console.ReadLine();
        Console.Write("What. . .  is your favorite color? ");
        string _color = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Very well! You may pass, Sir {_lastName}, the {_color} Knight!   Adieu.");
    }
}
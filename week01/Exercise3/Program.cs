using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to See/Saw");

        bool playing = true;

        do 
        {
            Random randomMagicNumGen = new Random();
            int magicNum = randomMagicNumGen.Next(1,101);
            Console.WriteLine("I'm thinking of a random number between 1 and 100. ");
            Console.Write("What number am I thinking of? >");

            int numGuess = int.Parse(Console.ReadLine());

            while (numGuess != magicNum)
            {
                string hilo;
                if (numGuess > magicNum)
                {
                    hilo = "high";
                }
                else
                {
                    hilo = "low";
                }

                Console.Write($"Nope! Too {hilo}. Guess again! >");
                numGuess = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Good job! You guessed it! ");
            Console.Write("Do you wanna go again? (Y/N) >");
            string contInput = Console.ReadLine();
            if (contInput == "y" || contInput == "Y")
            {
                playing = true;
            }
            else
            {
                playing = false;
            }

        } while (playing);

    Console.WriteLine("Goodbye!");

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Numbers Without Number!");
        Console.WriteLine("Enter numbers, enter 0 to end.");

        List<int> numList = new List<int>();
        int sum = 0;
        int bigNum = 0;

        bool running = true;
        while (running)
        {
            Console.Write("> ");
            int inNum = int.Parse(Console.ReadLine());
            
            if (inNum == 0)
            {
                running = false;
            }
            else
            {
                numList.Add(inNum);
                sum += inNum;
                if (inNum > bigNum)
                {
                    bigNum = inNum;
                }
            }
        }

        double average = sum / numList.Count;

        Console.WriteLine($"Sum: {sum} ");
        Console.WriteLine($"Mean: {average} ");
        Console.WriteLine($"Max Value: {bigNum} ");
    }
}
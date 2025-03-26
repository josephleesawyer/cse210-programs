using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        Journal journal = new();
        do 
        {
        Console.Clear();
        Console.WriteLine("Welcome to... ThE DiARY! (Dun dun dunnn)\r\nPick One:");
        Console.WriteLine("1. Write New Entry");
        Console.WriteLine("2. Display DiARY");
        Console.WriteLine("3. Save DiARY to file");
        Console.WriteLine("4. Load DiARY from file");
        Console.WriteLine("5. Clear Entries");
        Console.WriteLine("6. Exit");
        answer = Console.ReadLine();

        if (answer == "1")
        {
            journal.AddEntry();
            Console.Write("\r\nEntry Added.\r\n(Press Enter to Continue)\r\n");
            Console.ReadLine();
        }
        else if (answer == "2")
        {
            Console.WriteLine();
            journal.DisplayJournal();
        }
        else if (answer == "3")
        {
            Console.Write("What file would you like to save this DiARY to? \r\n>");
            string fileName = Console.ReadLine();
            journal.SaveTo(fileName);
            Console.Write("Diary Saved.\r\n(Press Enter to Continue)\r\n");
            Console.ReadLine();

        }
        else if (answer == "4")
        {
            string overwriteDecision = "";
            bool overwrite;
            Console.Write("What file would you like to load a DiARY from? \r\n>");
            string fileName = Console.ReadLine();
            do
            {
                Console.Write("Do wou want to: \r\nA. Overwite the current DiARY \r\nB. Add to the current DiARY \r\nC. Cancel (Return to Main Menu)\r\n>");
                overwriteDecision = Console.ReadLine();
            } while (overwriteDecision != "a" && overwriteDecision != "b" && overwriteDecision != "c" && overwriteDecision != "A" && overwriteDecision != "B" && overwriteDecision != "C");
            if (overwriteDecision == "a" || overwriteDecision == "A")
            {
                overwrite = true;
            }
            else
            {
                overwrite = false;
            }
            if (overwriteDecision != "c" && overwriteDecision != "C")
            {
                journal.LoadFrom(fileName, overwrite);
                Console.Write("Diary Loaded.\r\n(Press Enter to Continue)\r\n");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Load Canceled.\r\n(Press Enter to Continue)\r\n");
                Console.ReadLine();

            }
        }
        else if (answer == "5")
        {
            Console.Write("Are you sure you want to delete all entries and start a new DiARY?\r\n(y/n)\r\n>");
            string confirmation = Console.ReadLine();
            if (confirmation == "y") 
            {
                journal.ClearEntries();
                Console.Write("Diary Cleared.\r\n(Press Enter to Continue)\r\n");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Clear Canceled\r\n(Press Enter to Continue)\r\n");
                Console.ReadLine();
            }
        }
        } while (answer != "6" && answer != "x" && answer != "exit");

        Console.WriteLine("Have a pleasant day. ");
    }
}
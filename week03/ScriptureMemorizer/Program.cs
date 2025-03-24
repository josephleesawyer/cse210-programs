using System;

class Program
{
    static void Main(string[] args)
    {
        string sectionFourT = "   Now behold, a marvelous work is about to come forth among the children of men. ~Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, ~might, mind and strength, that ye may stand blameless before God at the last day. ~Therefore, if ye have desires to serve God ye are called to the work; ~For behold the field is white already to harvest; and lo, he that thrusteth in his sickle with his might, ~the same layeth up in store that he perisheth not, but bringeth salvation to his soul; ~And faith, hope, charity and love, with an eye single to the glory of God, qualify him for the work. ~Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence. ~Ask, and ye shall receive; knock, and it shall be opened unto you. Amen.";
        string peaceInChristT = "   Learn of me, and listen to my words; walk in the meekness of my Spirit, and you shall have peace in me.";
        string discipleOfChristT = "   Behold, I am a disciple of Jesus Christ, the Son of God. I have been called of him to declare his word among his people, ~that they might have everlasting life.";
        
        Reference sectionFourR = new ("D&C", 4, 1, 7);
        Reference peaceEnCristoR = new ("D&C", 19, 23);
        Reference discipleDeCristoR = new ("3 Nephi", 3, 15);

        Scripture sectionFour = new(sectionFourR, sectionFourT);
        Scripture peaceInChrist = new(peaceEnCristoR, peaceInChristT);
        Scripture discipleOfChrist = new(discipleDeCristoR, discipleOfChristT);

        List<Scripture> scripturesList = new();
        scripturesList.Add(discipleOfChrist);
        scripturesList.Add(peaceInChrist);
        scripturesList.Add(sectionFour);

        string gameMode = "";

        Console.Clear();
        Console.WriteLine("Welcome to THE MISTS OF DARKNESS!!!");
        Console.WriteLine("Can you keep hold to God's Word while confounding mists surround you? ");
        Console.Write("\r\nPress Enter to Continue.\r\n> ");
        Console.ReadLine();

        string answer;
        int myScriptIndex;
        bool lastRound = false;

        do
        {
            Console.Clear();
            Console.Write("Select a scripture:  \r\nA. 3 Nephi 3:15,  B. D&C 19:23,  or   C. D&C 4 (Hard Mode)  \r\n> ");
            answer = Console.ReadLine();
        } while (answer != "a" && answer != "b" && answer != "c" && answer != "A" && answer != "B" && answer != "C");
        
        if (answer == "a" || answer == "A")
        {
            myScriptIndex = 0;
        }
        else if (answer == "b" || answer == "B")
        {
            myScriptIndex = 1;
        }
        else
        {
            myScriptIndex = 2;
        }

        do
        {
            Console.Clear();
            Console.WriteLine("Pick Game Mode:");
            Console.Write("A. Disappearing Words,  B. Disappearing Letters\r\n> ");
                answer = Console.ReadLine();
        } while (answer != "a" && answer != "b" && answer != "A" && answer != "B");

        if (answer == "a" || answer == "A")
        {
            gameMode = "words";
        }
        else if (answer == "b" || answer == "B")
        {
            gameMode = "letters";
        }

        do
        {
            Console.Clear();
            Console.WriteLine(scripturesList[myScriptIndex].ScriptureDisplay());
            Console.Write("\r\nPress Enter to Continue   or   Enter 'quit' to finish.\r\n> ");
                answer = Console.ReadLine();

            if (scripturesList[myScriptIndex].IsAllHidden())
            {
                lastRound = true;
            }

            if (gameMode == "words")
            {
                scripturesList[myScriptIndex].HideRandomWord();
                scripturesList[myScriptIndex].HideRandomWord();
                scripturesList[myScriptIndex].HideRandomWord();
            }
            else
            {
                scripturesList[myScriptIndex].HideRandomLetter();
                scripturesList[myScriptIndex].HideRandomLetter();
                scripturesList[myScriptIndex].HideRandomLetter();
                scripturesList[myScriptIndex].HideRandomLetter();
                scripturesList[myScriptIndex].HideRandomLetter();
            }
        } while (answer != "quit" && answer != "q" && answer != "Q" && !lastRound);

        Console.WriteLine("Well done.");
    }
}
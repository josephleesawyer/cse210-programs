using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PRESS ENTER TO START");
        Console.ReadLine();

        // Listing Setup
        string p1 = "Who in your life do you love?";
        string p2 = "What is a strength for you?";
        string p3 = "What do you put a lot of effort into?";
        string p4 = "When have you felt the Holy Ghost?";
        string p5 = "WWhat things are you proud of?";
        string p6 = "Who have you made laugh recently?";

        List<string> pList = new List<string> {p1, p2, p3, p4, p5, p6};

        ListingActivity lAct = new("Listing", "This activity will help you to enumerate positive things in your life. You may be surprised by how many positive experiences you have!", pList);

        // Reflection Setup
        string rp1 = "When did you make an effort to defend someone?";
        string rp2 = "When have you done the right thing even when you wanted something else?";
        string rp3 = "When did you see a need and fill it?";
        string rp4 = "When have you followed a prompting that didn't make sense?";
        string rp5 = "When have you set aside your own wants for someone else's need?";
        string rp6 = "When did you do something that scared you?";

        List<string> rpList = new List<string> {rp1, rp2, rp3, rp4, rp5, rp6};

        string q1 = "What made you want to do that thing?";
        string q2 = "How did you feel afterwards?";
        string q3 = "What would you say to someone if they did that?";
        string q4 = "You did this. No one else. Think about that for a second. You chose it.";
        string q5 = "How were things different because of you?";
        string q6 = "What does that tell you about yourself?";

        List<string> qList = new List<string> {q1, q2, q3, q4, q5, q6};

        ReflectionActivity rAct = new("Reflection", "This activity will help you focus on moments in the past where you've shown strength and courage. \r\nYou are powerful, and you can do many great things. ", rpList, qList);
     
        // Breathing Setup
        BreathingActivity bAct = new("Breathing", "This activity will guide you to focus on your breathing. \r\nPay attention to how the air and your body move and interact together. \r\nNo matter where you are or what you are doing, you can can always meditate with your breathing. \r\nBreathe in and out with the Breathing bar below. \r\nBreathe low and deep and feel your diaphragm expand and exhale. ");

        // Act List Setup
        List<Activity> actList = new List<Activity> {lAct, rAct, bAct};

        Console.WriteLine("Welcome to the Mindfulness Center! Choose the activity you's like to try:");
        int actChoice = -3;
        while (actChoice != 3)
        {
            for (int i=0; i<3; i++)
            {
                Console.WriteLine($"{i+1}. {actList[i].GetName()}");
            }
            Console.WriteLine($"4. Quit");
            string answer = "";
            int choice = 0;
            do 
            {
                answer = Console.ReadLine();
            } while (!int.TryParse(answer, out choice));
            actChoice = choice - 1;
            if (actChoice != 3)
            {
                actList[actChoice].Run();
            }
        }
    }
}
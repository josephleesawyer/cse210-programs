using System.Runtime.InteropServices;

public class ReflectionActivity : Activity
{
    private List<string> _promptList;
    private List<string> _preguntas;
    private readonly string _asciimation = "|/-\\";
    // private string ascii2 = "v<^>";

    public ReflectionActivity(string actName, string actdesc, List<string> prompts, List<string> pregas) : base (actName, actdesc)
    {
        _promptList = prompts;
        _preguntas = pregas;
    }
    public override void Run()
    {
        SetupActivity();
        Console.WriteLine($"\r\n{GetRandomPrompt()}\r\n");
        // Console.Write($"Session starting in: ");
        // DisplayCountDownTimer(6);
        Console.WriteLine($"\r\nPress Enter When Ready\r\n");
        Console.Read();
        DateTime endTime = GetEndTime();
        do 
        {
            Console.WriteLine($"{GetRandomQ()}\r\n");
            for (int i = 0; i<37; i++)
            {
                Console.Write($"{_asciimation[i%4]}");
                Thread.Sleep(500);
                Console.Write($"\b \b");

            }
        } while (DateTime.Now < endTime);
        WrapUpActivity();

    }
    public string GetRandomPrompt()
    {
        Random rng = new();
        string promptChosen = _promptList[rng.Next(_promptList.Count)];
        return promptChosen;
    }
    public string GetRandomQ()
    {
        Random rnd = new();
        string qChosen = _preguntas[rnd.Next(_preguntas.Count)];
        return qChosen;
    }



}
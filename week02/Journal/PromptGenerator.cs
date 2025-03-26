using System;

public class PromptGenerator
{
    private string _prompt1 = "Did I have any meaningful interactions today?";
    private string _prompt2 = "Did I have any bizzare interactions today?";
    private string _prompt3 = "What am I grateful for?";
    private string _prompt4 = "Who did I meet today?";
    private string _prompt5 = "What did I eat today?";

    private List<string> _promptsList = new List<string>();
    
    // Constructor
    public PromptGenerator()
    {
        _promptsList.Add(_prompt1);
        _promptsList.Add(_prompt2);
        _promptsList.Add(_prompt3);
        _promptsList.Add(_prompt4);
        _promptsList.Add(_prompt5);
    }

    public string GetRandomPrompt()
    {
        string prompt;
        Random rnd = new();
        prompt = _promptsList[rnd.Next(_promptsList.Count)];
        return prompt;
    }


}
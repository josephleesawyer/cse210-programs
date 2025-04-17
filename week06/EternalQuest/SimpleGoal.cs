public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, int points) : base(name, points)
    {
        _isComplete = false;
    }
    public void MarkComplete()
    {
        _isComplete = true;
    }
    // to tell if it's done: 
    public override bool IsComplete()
    {
        return _isComplete;
    }
    // Achieve one step of mission
    public override int Achieve()
    {
        _isComplete = true;
        return GetPoints();
    }
    /// Display
    public override string DisplayText()
    {
        string display = "";
        string spacer = " ";
        if (IsComplete())
        {
            spacer = "1";
        }
        display += $" - {GetName()} ({GetPoints()} pts) ~ ({spacer}/1)";
        return display;
    }
    // savetext
    public override string SaveText()
    {
        string display = $"0[[[]]]{GetName()}[[[]]]{GetPoints()}///";
        
        return display;
    }
}
public class EternalGoal : Goal
{
    private int _amountCompleted;

    public EternalGoal(string name, int points) : base(name, points)
    {
        _amountCompleted = 0;
    }

    public void SetNum(int num)
    {
        _amountCompleted = num;
    }
    // to tell if it's done: 
    public override bool IsComplete()
    {
        return false;
    }
    // Achieve one step of mission
    public override int Achieve()
    {
        _amountCompleted++;
        return GetPoints();
    }
    /// Display
    public override string DisplayText()
    {
        string display = "";
        display += $" - {GetName()} ({GetPoints()} pts) ~ ({_amountCompleted}/∞)";
        return display;

    }
    // savetext
    public override string SaveText()
    {
        string display = $"1[[[]]]{GetName()}[[[]]]{GetPoints()}[[[]]]{_amountCompleted}///";

        return display;
    }
}
    

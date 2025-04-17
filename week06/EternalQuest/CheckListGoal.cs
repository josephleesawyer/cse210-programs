using System.Runtime;

public class CheckListGoal : Goal
{
    private int _bonus;
    private int _amountCompleted;
    private int _target;
    public CheckListGoal(string name, int points, int bonus, int target) : base(name, points)
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = 0;

    }
    // to tell if it's done: 
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
        public void SetNum(int num)
    {
        _amountCompleted = num;
    }

    // Achieve one step of mission
    public override int Achieve()
    {
        _amountCompleted++;
        int reward = GetPoints();
        if (IsComplete())
        {
            reward += _bonus;
        }
        return reward;
    }
    /// Display
    public override string DisplayText()
    {
        string display = "";
        display += $" - {GetName()} ({GetPoints()} pts) ~ ({_amountCompleted}/{_target})";
        return display;
    }
    // savetext
    public override string SaveText()
    {
        string display = $"2[[[]]]{GetName()}[[[]]]{GetPoints()}[[[]]]{_amountCompleted}[[[]]]{_bonus}[[[]]]{_target}///";
        
        return display;
    }

}
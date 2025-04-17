public abstract class Goal
{
    private string _goalName;
    private int _points;
    // Constructor
    public Goal(string name, int points)
    {
        _goalName = name;
        _points = points;
    }
    // to tell if it's done: 
    public abstract bool IsComplete();
    // Achieve one step of mission & Reward Player with Returned value
    public abstract int Achieve();
    /// Display
    public abstract string DisplayText();
    // savetext
    public abstract string SaveText();
    // Getter for parent points
    protected int GetPoints()
    {
        return _points;
    }
    protected string GetName()
    {
        return _goalName;
    }


}
using System; 
public class Fraction
{
    private int _topNum;
    private int _botNum; 
    public Fraction()
    {
        _topNum = 1;
        _botNum = 1;
    }
    public Fraction(int num1)
    {
        _topNum = num1;
        _botNum = 1;
    }
    public Fraction(int num1, int num2)
    {
        _topNum = num1;
        _botNum = num2;
    }
    public int GetTop()
    {
        return _topNum;
    }
    public int GetBot()
    {
        return _botNum;
    }
    public void SetTop(int value)
    {
        _topNum = value;
    }
    public void SetBot(int value)
    {
        _botNum = value;
    }
    public string GetFractionString()
    {
        return $"{_topNum}/{_botNum}";
    }
    public double GetDecimalValue()
    {
        return (double)_topNum / (double)_botNum;
    }
}
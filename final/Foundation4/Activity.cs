
class Activity
{
    private string _date;
    private int _length;
    private double _dummy = 0;


    public void GetSummary()
    {
        Console.WriteLine($"{GetDate()} {GetType()} ({GetLength()} min)- Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile");
    }

    public virtual double CalculateSpeed()
    {
        return _dummy;
    }
    public virtual double CalculateDistance()
    {
        return _dummy;
    }
    public virtual double CalculatePace()
    {
        return _dummy;
    }
    public void SetLength(int length)
    {
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetDate()
    {
        return _date;
    }
}

class Running : Activity
{
    private double _distance;

    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public double GetDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }
    public override double CalculatePace()
    {
        return GetLength() / (GetDistance());
    }
    public override double CalculateDistance()
    {
        return _distance;
    }
}
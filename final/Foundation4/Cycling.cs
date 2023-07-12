
class Cycling : Activity
{
    private double _speed;

    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    public double GetSpeed()
    {
        return _speed;
    }
    public override double CalculateDistance()
    {
        return GetLength() / CalculatePace();
    }
    public override double CalculatePace()
    {
        return 60 / GetSpeed();
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }

    
}
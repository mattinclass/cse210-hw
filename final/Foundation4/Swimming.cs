
class Swimming : Activity
{
    private int _laps;
    public override double CalculateSpeed()
    {
        return (CalculateDistance() * GetLength()) / 60;
    }
    public override double CalculateDistance()
    {
        return GetLaps() * 50 / 620;
    }
    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }
    public void SetLaps(int laps)
    {
        _laps = laps;
    }
    public int GetLaps()
    {
        return _laps;
    }
}
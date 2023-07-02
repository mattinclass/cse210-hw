
class EternalGoal : Goal
{
    private string _type = "Eternal Goal";

    public override void CreateGoal()
    {
        Console.WriteLine("What is your new eternal goal?");
        string mystatement = Console.ReadLine();
        SetStatement(mystatement);

        Console.WriteLine("What is the point value for each time you complete this goal?");
        int myvalue = Int32.Parse(Console.ReadLine());
        SetPointValue(myvalue);
    }

    public override string GetGoalType()
    {
        return _type;
    }
}
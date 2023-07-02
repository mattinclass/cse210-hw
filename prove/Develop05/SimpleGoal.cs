
class SimpleGoal : Goal
{
    

    private string _type = "Simple Goal";
    public override void CreateGoal()
    {
        Console.WriteLine("What is your new simple goal?");
        string mystatement = Console.ReadLine();
        SetStatement(mystatement);

        Console.WriteLine("What is the point value of this goal?");
        int myvalue = Int32.Parse(Console.ReadLine());
        SetPointValue(myvalue);
        
    }
    public override string GetGoalType()
    {
        return _type;
    }
}
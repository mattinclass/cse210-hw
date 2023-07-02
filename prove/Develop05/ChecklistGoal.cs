
class ChecklistGoal : Goal
{
    private string _type = "Checklist Goal";
    

    public override void CreateGoal()
    {
        Console.WriteLine("What is your new checklist goal?");
        string mystatement = Console.ReadLine();
        SetStatement(mystatement);

        Console.WriteLine("How many times must the goal be completed for the bonus points?");
        int completionNumber = Int32.Parse(Console.ReadLine());
        SetCompletionNumber(completionNumber);

        Console.WriteLine("How many points will you receive after completing the goal once?");
        int myvalue = Int32.Parse(Console.ReadLine());
        SetPointValue(myvalue);

        Console.WriteLine("How many bonus points will you receive after fully completing the goal?");
        int bonus = Int32.Parse(Console.ReadLine());
        SetBonus(bonus);

        isChecklist = true;
    }

    public override string GetGoalType()
    {
        return _type;
    }

    
    
}
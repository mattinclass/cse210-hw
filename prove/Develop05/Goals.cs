using System.IO;
class Goals
{
    public List<Goal> goalList = new List<Goal>();
    private int _totalScore = 0;
    private string _goalType;

    public virtual void SaveGoals()
    {
        Console.WriteLine("What do you want to name your file?");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            

            foreach (Goal goal in goalList)
            {
                if (goal.isChecklist == true)
                {
                    outputFile.WriteLine($"{goal.GetGoalType()}:{goal.GetStatement()},{goal.GetPointValue()},{goal.GetBonus()},{goal.GetNumberCompleted()}/{goal.GetCompletionNumber()},{goal.DisplayGoalStatus()}");
                }
                else if (goal.GetGoalType() == "Eternal Goal")
                {
                    outputFile.WriteLine($"{goal.GetGoalType()}:{goal.GetStatement()},{goal.GetPointValue()},{goal.GetTimesCompleted()}");
                }
                else
                {
                    outputFile.WriteLine($"{goal.GetGoalType()}:{goal.GetStatement()},{goal.GetPointValue()},{goal.DisplayGoalStatus()}");
                }
                
            }
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file you want to load?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        string loadStatement;
        int loadValue;
        string isitcomplete;
        int loadBonus;
        int loadtimescompleted;
        int loadrequiredcomplete;

        foreach (string line in lines)
        {
            string[] goalparts = line.Split(":");
            

            
            
            if (goalparts[0] == "Simple Goal")
            {
                string[] simpleparts = goalparts[1].Split(",");
                
                
                loadStatement = simpleparts[0].ToString();
                string loadValuestring = simpleparts[1];
                    
                loadValue = Int32.Parse(loadValuestring);
                isitcomplete = simpleparts[2].ToString();

                
                SimpleGoal newSimpleGoal = new SimpleGoal();
                newSimpleGoal.SetStatement(loadStatement);
                newSimpleGoal.SetPointValue(loadValue);
                newSimpleGoal.SetGoalStatus(isitcomplete);
                if (isitcomplete == "[X]")
                {
                    _totalScore += loadValue;
                }
                goalList.Add(newSimpleGoal);
            }

            else if (goalparts[0] == "Checklist Goal")
            {
                string[] checklistparts = goalparts[1].Split(",");
                
                
                loadStatement = checklistparts[0].ToString();
                string loadValuestring = checklistparts[1];
                    
                loadValue = Int32.Parse(loadValuestring);
                
                
                loadBonus = Int32.Parse(checklistparts[2]);

                string [] slash = checklistparts[3].Split("/");
                
                loadtimescompleted = Int32.Parse(slash[0]);
                loadrequiredcomplete = Int32.Parse(slash[1]);
                isitcomplete = checklistparts[4];

                ChecklistGoal newChecklistGoal = new ChecklistGoal();
                newChecklistGoal.SetStatement(loadStatement);
                newChecklistGoal.SetPointValue(loadValue);
                newChecklistGoal.SetBonus(loadBonus);
                newChecklistGoal.SetNumberCompleted(loadtimescompleted);
                newChecklistGoal.SetCompletionNumber(loadrequiredcomplete);
                newChecklistGoal.SetGoalStatus(isitcomplete);
                _totalScore += loadtimescompleted*loadValue;
                if (isitcomplete == "[X]")
                {
                    _totalScore += loadBonus;
                }
                goalList.Add(newChecklistGoal);


            }

            else if (goalparts[0] == "Eternal Goal")
            {
                string[] eternalparts = goalparts[1].Split(",");
                
                
                loadStatement = eternalparts[0].ToString();
                string loadValuestring = eternalparts[1];
                    
                loadValue = Int32.Parse(loadValuestring);
                int completed = Int32.Parse(eternalparts[2]);

                
                EternalGoal newEternalGoal = new EternalGoal();
                newEternalGoal.SetStatement(loadStatement);
                newEternalGoal.SetPointValue(loadValue);
                _totalScore += loadValue * completed;
                goalList.Add(newEternalGoal);
            }
            

            

            
        }
        
    }


    public void DisplayGoals()
    {
        int order = 1;
        foreach (Goal goal in goalList)
        {

            string words = goal.GetStatement();
            int value = goal.GetPointValue();
            if (goal.GetGoalType() == "Checklist Goal")
            {
                Console.WriteLine($"{order}. {words}, {goal.GetPointValue()} ea, {goal.GetBonus()} points bonus. {goal.GetNumberCompleted()}/{goal.GetCompletionNumber()} complete. {goal.DisplayGoalStatus()}");
            }
            else if (goal.GetGoalType() == "Simple Goal")
            {
                Console.WriteLine($"{order}. {words}, {value} points. {goal.DisplayGoalStatus()}");
            }
            else
            {
                Console.WriteLine($"{order}. {words}, {value} points each time it's completed.");
            }

            order ++;
            
        }
        Thread.Sleep(2000);
    }
    public virtual void CreateGoal()
    {
        Console.WriteLine("What type of goal are you setting?\n1. Simple Goal\n2. Checklist Goal\n3. Eternal Goal");
        _goalType = Console.ReadLine();
        if (_goalType == "1")
        {
            SimpleGoal mySimpleGoal = new SimpleGoal();
            
            mySimpleGoal.CreateGoal();
            goalList.Add(mySimpleGoal);
        }
        if (_goalType == "2")
        {
            ChecklistGoal myChecklistGoal = new ChecklistGoal();
            myChecklistGoal.CreateGoal();
            goalList.Add(myChecklistGoal);
        }
        if (_goalType == "3")
        {
            EternalGoal myEternalGoal = new EternalGoal();
            myEternalGoal.CreateGoal();
            goalList.Add(myEternalGoal);
        }
        
    }

    public void RecordEvent()    
    {
        
        
        

        DisplayGoals();
        Console.WriteLine("Which goal has been completed?");
        int selection = Int32.Parse(Console.ReadLine());
        if (goalList[selection-1].GetGoalType() == "Simple Goal")
        {
            if (goalList[selection-1].DisplayGoalStatus() == "[X]")
            {
                Console.WriteLine("You've already completed this goal and received the points for it.");
            }
            else
            {
                _totalScore += goalList[selection-1].GetPointValue();
                goalList[selection-1].MarkComplete();
                Console.WriteLine("The goal has been marked complete and you have received the points.");
            }
            
        }
        else if (goalList[selection-1].GetGoalType() == "Eternal Goal")
        {
            _totalScore += goalList[selection-1].GetPointValue();
            goalList[selection-1].SetTimesCompleted();
            Console.WriteLine("You have received the points.");
        }
        else
        {
            if (goalList[selection-1].DisplayGoalStatus() == "[X]")
            {
                Console.WriteLine("You've already received the points for this goal!");
            }
            else if (goalList[selection-1].GetNumberCompleted() < goalList[selection-1].GetCompletionNumber())
            {
                int numberCompleted =goalList[selection-1].GetNumberCompleted();
                int value = goalList[selection-1].GetPointValue();
                
                goalList[selection-1].SetNumberCompleted(numberCompleted+1);
                
                _totalScore += value;
                if (goalList[selection-1].GetNumberCompleted() == goalList[selection-1].GetCompletionNumber())
                {
                    int bonus = goalList[selection-1].GetBonus();
                    _totalScore += bonus;
                    goalList[selection-1].MarkComplete();
                }
            }
        }
            
        
    }
    public int GetTotalScore()
    {
        return _totalScore;
    }

    public void RemoveGoal()
    {
        DisplayGoals();
        Console.WriteLine("Which goal do you want to remove from the list?");
        int selection = Int32.Parse(Console.ReadLine());
        goalList.RemoveAt(selection-1);
        
    }

    

    

    
}
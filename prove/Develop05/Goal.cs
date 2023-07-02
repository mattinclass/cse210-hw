
class Goal : Goals
{
    private string _statement;
    private int _pointValue;
    private bool _isComplete = false;
    public bool isChecklist = false;

    private int _completionNumber;
    private int _numberCompleted = 0;

    private int _bonusValue;
    private int _timesCompleted;



    public void SetStatement(string statement)
    {
        _statement = statement;
    }

    public void SetPointValue(int value)
    {
        _pointValue = value;
    }

    public string GetStatement()
    {
        return _statement;
    }
    public int GetPointValue()
    {
        return _pointValue;
    }

    public void SetCompletionNumber(int completionNumber)
    {
        _completionNumber = completionNumber;
    }
    public void SetBonus(int bonus)
    {
        _bonusValue = bonus;
    }
    public int GetCompletionNumber()
    {
        return _completionNumber;
    }
    public int GetBonus()
    {
        return _bonusValue;
    }
    public int GetNumberCompleted()
    {
        return _numberCompleted;
    }
    public string DisplayGoalStatus()
    {
        string graphic = "[ ]";
        if (_isComplete)
        {
            graphic = "[X]";
        }
        return graphic;
    }
    
    public virtual string GetGoalType()
    {
        return _statement;
    }
    public void SetGoalStatus(string status)
    {
        if (status == "[ ]")
        {
            _isComplete = false;
        }
        else if (status == "[X]")
        {
            _isComplete = true;
        }
    }
    public void SetNumberCompleted(int number)
    {
        _numberCompleted = number;
    }
    public void MarkComplete()
    {
        _isComplete = true;
        
    }
    public void SetTimesCompleted()
    {
        _timesCompleted += 1;
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    
    
}
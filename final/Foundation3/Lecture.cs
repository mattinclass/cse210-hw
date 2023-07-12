
class Lecture : Event
{
    private string _type = "Lecture";
    private string _speaker;
    
    private int _capacity;


    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public void GenerateFullDetails()
    {
        GenerateStandardDetails();
        Console.WriteLine($"Event Type: Lecture by {GetSpeaker()}.\n{GetCapacity()} seats available.");
    }
    public void GenerateShortDescription()
    {
        Console.WriteLine($"Event Type: {_type}\nTitle: {GetTitle()}\n{GetDate()}");
    }
}
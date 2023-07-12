
class Reception : Event
{
    private string _type = "Reception";
    private string _email;

    public void SetEmail(string email)
    {
        _email = email;
    }
    public string GetEmail()
    {
        return _email;
    }

    public void GenerateFullDetails()
    {
        GenerateStandardDetails();
        Console.WriteLine($"RSVP at {GetEmail()}");
    }
    public void GenerateShortDescription()
    {
        Console.WriteLine($"Event Type: {_type}\nTitle: {GetTitle()}\n{GetDate()}");
    }
}

class Outdoor : Event
{
    private string _type = "Outdoor Get-Together";
    private string _weather;

    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }
    public void GenerateFullDetails()
    {
        GenerateStandardDetails();
        Console.WriteLine($"Expect {GetWeather()} weather.");
    }
    public void GenerateShortDescription()
    {
        Console.WriteLine($"Event Type: {_type}\nTitle: {GetTitle()}\n{GetDate()}");
    }
}
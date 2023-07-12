
class Event
{
    public Address theAddress = new Address();
    private string _title;
    private string _date;
    private string _time;
    

    public void GenerateStandardDetails()
    {
        Console.WriteLine($"{GetTitle()}\nDate: {GetDate()}\nTime: {GetTime()}\nAddress: {theAddress.GetAddress()} ");

        
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetTime(string time)
    {
        _time = time;
    }
    public string GetTime()
    {
        return _time;
    }
    
}
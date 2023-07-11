
class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;


    public bool CheckLocation()
    {
        bool inUSA;
        if (_country == "USA")
        {
            inUSA = true;
        }
        else
        {
            inUSA = false;
        }
        
        return inUSA;    
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public string GetAddress()
    {
        string address = $"{_streetAddress} \n{_city}, {_state}, {_country}";
        return address;
    }
}
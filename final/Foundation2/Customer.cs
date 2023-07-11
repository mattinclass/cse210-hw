
class Customer
{
    private string _customerName;
    public Address customerAddress = new Address();

    public Customer()
    {
        Address customerAddress = new Address();
    }

    public bool CheckLocationC()
    {
        return customerAddress.CheckLocation();
    }
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
}

class Order
{
    public List<Product> productList = new List<Product>();
    public Customer myCustomer = new Customer();
    private int _cost = 0;
    private int _shippingCost;
    public Order()
    {
        Customer myCustomer = new Customer();
        List<Product> productList = new List<Product>();
    }

    public string CalculateTotalCost()
    {
        foreach (Product product in productList)
        {
            _cost += product.GetProductPrice();
        }
        if (myCustomer.CheckLocationC() == true)
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        return $"Total Cost: ${_cost + _shippingCost}";
    }
    public void CreatePackingLabel()
    {
        foreach (Product product in productList)
        {
            Console.WriteLine($"{product.GetProductName()}, ID#: {product.GetProductID()}");
        }
        
    }
    public void CreateShippingLabel()
    {
        Console.WriteLine($"Name: {myCustomer.GetCustomerName()}\nAddress: {myCustomer.customerAddress.GetAddress()}");
    }
}
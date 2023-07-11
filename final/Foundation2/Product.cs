
class Product
{
    private string _productName;
    private string _productID;
    private int _price;
    private int _quantity = 0;

    public int GetProductPrice()
    {
        int price = _price * _quantity;
        return price;
    }
    public void SetProductName(string productName)
    {
        _productName = productName;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public void SetProductID(string productID)
    {
        _productID = productID;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public void SetProductPrice(int productPrice)
    {
        _price = productPrice;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    
}
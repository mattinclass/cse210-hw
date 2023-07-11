using System;

class Program
{
    static void Main(string[] args)
    {
        Order orderOne = new Order();
        Order orderTwo = new Order();

        Product hammer = new Product();
        Product screwdriver = new Product();
        Product wrench = new Product();
        Product screw = new Product();
        Product nail = new Product();
        Product level = new Product();
        Product sandpaper = new Product();

        hammer.SetProductName("hammer"); hammer.SetProductID("G040"); hammer.SetProductPrice(35); hammer.SetQuantity(1);
        screwdriver.SetProductName("screwdriver"); screwdriver.SetProductID("D50"); screwdriver.SetProductPrice(20); screwdriver.SetQuantity(2);
        wrench.SetProductName("wrench"); wrench.SetProductID("WD42"); wrench.SetProductPrice(30); wrench.SetQuantity(1);
        screw.SetProductName("screw"); screw.SetProductID("S11"); screw.SetProductPrice(1); screw.SetQuantity(40);
        nail.SetProductName("nail"); nail.SetProductID("N11"); nail.SetProductPrice(1); nail.SetQuantity(32);
        level.SetProductName("level"); level.SetProductID("L090"); level.SetProductPrice(8); level.SetQuantity(1);
        sandpaper.SetProductName("sandpaper"); sandpaper.SetProductID("SP811"); sandpaper.SetProductPrice(5); hammer.SetQuantity(3);

        orderOne.myCustomer.SetCustomerName("Alejandro Riveros");
        orderOne.myCustomer.customerAddress.SetAddress("403 La Vista", "La Tablada", "Buenos Aires", "Argentina");
        orderOne.productList.Add(sandpaper);
        orderOne.productList.Add(hammer);
        orderOne.productList.Add(nail);
        Console.WriteLine(orderOne.CalculateTotalCost());
        orderOne.CreatePackingLabel();
        orderOne.CreateShippingLabel();

        Console.WriteLine();
        
        orderTwo.myCustomer.SetCustomerName("John Jimmy");
        orderTwo.myCustomer.customerAddress.SetAddress("1234 Goon Lane", "New York City", "New York", "USA");
        orderTwo.productList.Add(screwdriver);
        orderTwo.productList.Add(screw);
        orderTwo.productList.Add(level);
        orderTwo.productList.Add(wrench);
        Console.WriteLine(orderTwo.CalculateTotalCost());
        orderTwo.CreatePackingLabel();
        orderTwo.CreateShippingLabel();
    }
}
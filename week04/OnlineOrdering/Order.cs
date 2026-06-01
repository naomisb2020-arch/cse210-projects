using System;

class Order
{

    private List<Product> _product = new List<Product>();
    private Customer _customer; 

    

    public Order(List<Product> product, Customer customer)
    {
        _product = product;
        _customer = customer;
    }

    public double CalculateTotalPrice()
    {
        
        double totalPrice = 0;
        foreach (Product p in _product)
        {
            totalPrice = totalPrice + p.CalculateTotalCost();

        }
        
        if (_customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "--- PACKING LABEL ---\n";

        foreach (Product p in _product)
        {
            packingLabel += $"ID: {p.GetProductId()} | Name: {p.GetName()}\n";
        }

        return packingLabel;
    }
    public string GetShippingLabel()
    {
        string shippingLabel = "--- SHIPPING LABEL ---\n";

        shippingLabel += $"Customer: {_customer.GetName()}\n";
        shippingLabel += $"Address:\n{_customer.GetAddress().GetFullAddress()}\n";

        return shippingLabel;
    }
    public void DisplayOrderDetails()
    {
        Console.WriteLine(GetPackingLabel());
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine($"Total Price: ${CalculateTotalPrice():f2}");
        Console.WriteLine(new string('=', 40) + "\n");
    }
}
using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public Order(Customer customer, Product product)
    {
        _customer = customer;
        AddProduct(product);
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetCustomerName()
    {
        return _customer.GetName();
    }

    public float OrderTotal()
    {
        float priceSum = 0f;
        float shipping = 5f;

        foreach(Product product in _products)
        {
            priceSum = product.TotalPrice();
        }

        if (_customer.America())
        {
            shipping += 30;
        }
        return priceSum + shipping;
        
    }

    public void PackingLable()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"ID:{product.GetName()} - {product.GetProductID()}");
        }
        ;
    }

    public void ShippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.DisplayAddress()}");
        
    }
}
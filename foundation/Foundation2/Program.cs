using System;

class Program
{
    static void Main(string[] args)
    {




        
        Customer customer1 = new Customer("Joshua Smith", new Address("25 Whitacker Way", "Edmonton", "Alberta", "Canada"));
        Customer customer2 = new Customer("Charles Farara", new Address("10827 99th St", "Lexington", "New York", "USA"));

        
        Order order1 = new Order(customer1, new Product("Basketball", 244516, 10.99f, 1));
        order1.AddProduct(new Product("Nails", 2244, .99f, 27));
        order1.AddProduct(new Product("Chocolate Bar", 1234508, 5.99f, 3)); 

        Console.WriteLine($"Order 1:");
        Console.WriteLine("");
        Console.WriteLine(customer1.GetName());
        Console.WriteLine("");
        Console.WriteLine($"Items:");
        order1.PackingLable();
        Console.WriteLine("");
        Console.WriteLine($"Send to:");
        order1.ShippingLabel();
        Console.WriteLine("");
        Console.WriteLine($"Total Cost: {order1.OrderTotal()}");

        Console.WriteLine("");
        Console.WriteLine("##################################");
        Console.WriteLine("");

        Order order2 = new Order(customer2, new Product("Butter", 15884, 4.99f, 6));
        order2.AddProduct(new Product("Cucumber", 4455, 2.99f, 3));
        order2.AddProduct(new Product("Pumpkin Pie", 601230983, 14.99f, 2));
        order2.AddProduct(new Product("Turkey", 2094, 50.99f, 1));

        Console.WriteLine($"Order 2:");
        Console.WriteLine("");
        Console.WriteLine(customer2.GetName());
        Console.WriteLine("");
        Console.WriteLine($"Items:");
        order2.PackingLable();
        Console.WriteLine("");
        Console.WriteLine($"Send to:");
        order2.ShippingLabel();
        Console.WriteLine("");
        Console.WriteLine($"Total Cost: {order2.OrderTotal()}");



    }
}
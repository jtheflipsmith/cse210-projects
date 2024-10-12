using System.Collections.Concurrent;
using System.Net.Sockets;
using Microsoft.VisualBasic;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string DisplayAddress()
    {
        return _address.DisplayAddress();
    }
    public bool America()
    {
        return _address.AmericanOrNot();
    }

}
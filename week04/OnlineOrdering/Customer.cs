using System;

public class Customer
{
    private string _custName;
    private Address _custAddress;
    public Customer(string name, Address addy)
    {
        _custName = name;
        _custAddress = addy;
    }
    public bool IsInUSA()
    {
        if (_custAddress.IsInUSA())
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    public string NameAndAddress()
    {
        string display = $"{_custName}\r\n\r\n{_custAddress.AddressDisplay()}";
        return display;
    }
}
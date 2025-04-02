using System;

public class Address
{
    private string _streetAddy;
    private string _city;
    private string _stateOrProv;
    private string _country;
    public Address(string streetAddy, string city, string state, string country)
    {
        _streetAddy = streetAddy;
        _city = city;
        _stateOrProv = state;
        _country = country;
    }
    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    public string AddressDisplay()
    {
        string display = $"{_streetAddy}\r\n{_city}, {_stateOrProv}\r\n{_country}";
        return display;
    }
}
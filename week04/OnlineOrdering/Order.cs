using System;

public class Order
{
    private List<Product> _prodList;
    private Customer _customer;
    private float _usaShipFee;
    private float _outShipFee;
    public Order(Customer customer, List<Product> prodList)
    {
        _customer = customer;
        _prodList = prodList;
        _usaShipFee = 5;
        _outShipFee = 35;
    }
    public double CalcOrderTotal()
    {
        double cost = 0;
        foreach (Product product in _prodList)
        {
            cost += product.CalcProdCost();
            if (_customer.IsInUSA())
            {
                cost += _usaShipFee;
            }
            else
            {
                cost += _outShipFee;
            }
        }
        return cost;
    }
    public string PackingLabel()
    {
        string display = "";
        foreach (Product prod in _prodList)
        {
            display += $"{prod.NameAndID()}\r\n";
        }
        return display;
    }
    public string ShippingLabel()
    {
        string display = $"{_customer.NameAndAddress()}";
        return display;
    }
}
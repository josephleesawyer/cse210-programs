using System;

public class Product
{
    private string _prodName;
    private string _productID;
    private double _price;
    private double _quantity;
    public Product(string name, string prodID, double precio, double quant)
    {
        _prodName = name;
        _productID = prodID;
        _price = precio;
        _quantity = quant;
    }
    public double CalcProdCost()
    {
        double cost = _price * _quantity;
        return cost;
    }
    public string NameAndID()
    {
        string display = $"x{_quantity} {_prodName}     {_productID}";
        return display;
    }
}
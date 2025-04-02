using System;
class Program
{
    static void Main(string[] args)
    {
        Product prod1 = new("Fish", "53U55", 3.14, 1);
        Product prod2 = new("Fish", "53U55", 3.14, 2);
        Product prod3 = new("Red Fish", "D0C70R", 12.34, 1);
        Product prod4 = new("Blue Fish", "G31552L", 91.80, 1);
        
        Address addy1 = new("1234 Sesame Street", "Gotham", "Rhode Island", "USA");
        Address addy2 = new("12-B 'Tween the Lions", "Dragonland", "Warr' Drobe", "Papa New Guinea");

        Customer cust1 = new("Juan Paco Pedro de la Mar", addy1);
        Customer cust2 = new("Esmy Nombresi", addy2);

        List<Product> pl1 = new();
        pl1.Add(prod1);
        pl1.Add(prod2);
        List<Product> pl2 = new();
        pl2.Add(prod3);
        pl2.Add(prod4);

        Order ord1 = new(cust1, pl1);
        Order ord2 = new(cust2, pl2);
        
        List<Order> ordList = new();
        ordList.Add(ord1);
        ordList.Add(ord2);
        
        foreach (Order ord in ordList)
        {
            Console.WriteLine($"\r\n\r\n\r\n\r\nShip to:\r\n{ord.ShippingLabel()}\r\n\r\nPacking List: \r\n{ord.PackingLabel()}\r\n\r\nTotal: ${Math.Round(ord.CalcOrderTotal(), 2, MidpointRounding.AwayFromZero)}");
        }     
    }
}
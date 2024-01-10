// Order.cs

using System;
using System.Collections.Generic;

public class Order
{
    public int OrderId { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();

    public Order(int orderId)
    {
        OrderId = orderId;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void Display()
    {
        Console.WriteLine($"Order ID: {OrderId}");
        foreach (var product in Products)
        {
            product.Display();
        }
    }
}

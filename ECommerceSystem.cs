// ECommerceSystem.cs

using System;
using System.Collections.Generic;

public class ECommerceSystem
{
    private List<Product> products = new List<Product>();
    private List<Order> orders = new List<Order>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void CreateOrder(Order order)
    {
        orders.Add(order);
    }

    public void DisplayProducts()
    {
        Console.WriteLine("Available Products:");
        foreach (var product in products)
        {
            product.Display();
        }
    }

    public void DisplayOrders()
    {
        Console.WriteLine("Order History:");
        foreach (var order in orders)
        {
            order.Display();
        }
    }
}

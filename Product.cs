// Product.cs

using System;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int productId, string name, double price)
    {
        ProductId = productId;
        Name = name;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine($"Product ID: {ProductId}, Name: {Name}, Price: ${Price}");
    }
}

// Program.cs

class Program
{
    static void Main()
    {
        // Create products
        var laptop = new Product(1, "Laptop", 800.0);
        var smartphone = new Product(2, "Smartphone", 400.0);

        // Create orders
        var order1 = new Order(101);
        order1.AddProduct(laptop);
        order1.AddProduct(smartphone);

        var order2 = new Order(102);
        order2.AddProduct(smartphone);

        // Create an e-commerce system
        var eCommerceSystem = new ECommerceSystem();

        // Add products to the system
        eCommerceSystem.AddProduct(laptop);
        eCommerceSystem.AddProduct(smartphone);

        // Create orders and add them to the system
        eCommerceSystem.CreateOrder(order1);
        eCommerceSystem.CreateOrder(order2);

        // Display available products and order history
        eCommerceSystem.DisplayProducts();
        eCommerceSystem.DisplayOrders();
    }
}

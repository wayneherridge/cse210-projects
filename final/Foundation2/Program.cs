using System;

class Program
{
    static void Main(string[] args)
    {
        // Create address objects
        Address usaAddress = new Address("123 Main St", "New York", "NY", "USA");
        Address intlAddress = new Address("18 Deerhurst Crescent", "Portsmouth", "Hampshire", "UK");

        // Create customer objects
        Customer customer1 = new Customer("John Doe", usaAddress);
        Customer customer2 = new Customer("Wayne Herridge", intlAddress);

        // Create product objects
        Product product1 = new Product("Keyboard", "W123", 10.99m, 2);
        Product product2 = new Product("Joystick", "G456", 19.99m, 1);
        Product product3 = new Product("Mouse", "T789", 5.99m, 3);
        Product product4 = new Product("Monitor", "M300", 160m,1);
        Product product5 = new Product("Speakers", "S002", 10m,3);
        Product product6 = new Product("Webcam", "WCAM", 80m, 1);

        // Create order objects
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product3);
        order1.AddProduct(product5);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product4);
        order2.AddProduct(product6);

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("======================================================");
        Console.WriteLine("         Encapsulation with Online Ordering           ");
        Console.WriteLine("======================================================");
        Console.ResetColor();
        Console.WriteLine();

        // Calculate and display results
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Order 1");
        Console.WriteLine("=======");
        Console.ResetColor();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Order 2");
        Console.WriteLine("=======");
        Console.ResetColor();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());

        Console.ReadLine();
    }
}

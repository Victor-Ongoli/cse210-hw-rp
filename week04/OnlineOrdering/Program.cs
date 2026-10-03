using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        //ORDER 1: KENYA Customer
        Address address1 = new Address("Port Malindi", "Karen", "ID", "Kenya");
        Customer customer1 = new Customer("Macliness Mwanisa", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P001", 899.99, 1));
        order1.AddProduct(new Product("Mouse", "P002", 19.99, 2));

        Console.WriteLine("=============================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("=================================");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        // --- ORDER 2: International Customer
        Address address2 = new Address("Kingston", "Jamaica", "ON", "Carribean");
        Customer customer2 = new Customer("Benjamin Haira", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Keyboard", "P003", 49.99, 1));
        order2.AddProduct(new Product("Monitor", "P004", 199.99, 2));
        order2.AddProduct(new Product("HDMI Cable", "P005", 12.50, 3));

        Console.WriteLine("=================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("=================================");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}
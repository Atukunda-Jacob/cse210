using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Kampala", "Central", "Uganda");
        Customer customer1 = new Customer("Atukunda Jacob", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop Stand", "L001", 25.99, 1));
        order1.AddProduct(new Product("Wireless Mouse", "M002", 15.50, 2));

        Address address2 = new Address("456 Elm St", "New York", "NY", "USA");
        Customer customer2 = new Customer("John Doe", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "MN004", 150.00, 1));
        order2.AddProduct(new Product("HDMI Cable", "H005", 10.00, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}\n");
    }
}

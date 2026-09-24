using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Kampala", "Central", "Uganda");
        Customer customer1 = new Customer("Jacob Atukunda", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L001", 800, 1));
        order1.AddProduct(new Product("Mouse", "M002", 25, 2));

        Address address2 = new Address("456 Elm St", "Provo", "UT", "USA");
        Customer customer2 = new Customer("John Doe", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Book", "B003", 15, 3));
        order2.AddProduct(new Product("Pen", "P004", 2, 10));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating addresses
        Address addressUSA = new Address("123 Main St", "Anytown", "NY", "USA");
        Address addressNonUSA = new Address("456 Elm St", "Othertown", "Ontario", "Canada");

        // Creating customers
        Customer customer1 = new Customer("Alice", addressUSA);
        Customer customer2 = new Customer("Bob", addressNonUSA);

        // Creating products
        List<Product> productsOrder1 = new List<Product>
        {
            new Product("Laptop", "LPT001", 1000, 1),
            new Product("Mouse", "MS001", 20, 2)
        };

        List<Product> productsOrder2 = new List<Product>
        {
            new Product("Headphones", "HP001", 50, 1),
            new Product("Keyboard", "KB001", 80, 1),
            new Product("Monitor", "MN001", 300, 1)
        };

        // Creating orders
        Order order1 = new Order(customer1, productsOrder1);
        Order order2 = new Order(customer2, productsOrder2);

        // Displaying results
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nOrder 1 Total Price:");
        Console.WriteLine("$" + order1.GetTotalPrice());

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nOrder 2 Total Price:");
        Console.WriteLine("$" + order2.GetTotalPrice());
    }
}

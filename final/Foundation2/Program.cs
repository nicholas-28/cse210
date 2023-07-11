using System;
using System.Collections.Generic;
class Program
{
public static void Main(string[] args)
{
    // Create some products
    Product product1 = new Product("Apple iPhone 13", "AIP13", 999, 2);
    Product product2 = new Product("Samsung Galaxy S22", "SGS22", 899, 1);
    Product product3 = new Product("HP Laptop", "HPL789", 550, 3);
    Product product4 = new Product("JBL Bluetooth Speaker", "JBLBS99", 150, 1);

    // Create some addresses
    Address address1 = new Address("123 Silicon Valley", "San Jose", "CA", "USA");
    Address address2 = new Address("456 Maple St", "Toronto", "ON", "Canada");

    // Create some customers
    Customer customer1 = new Customer("John Doe", address1);
    Customer customer2 = new Customer("Jane Smith", address2);

    // Create some orders and add products
    Order order1 = new Order(customer1);
    order1.AddProduct(product1);
    order1.AddProduct(product2);

    Order order2 = new Order(customer2);
    order2.AddProduct(product3);
    order2.AddProduct(product4);

    // Create a list of orders
    List<Order> orders = new List<Order> { order1, order2 };

    // Loop through each order and display its details
    foreach (Order order in orders)
    {
        Console.WriteLine("Order Details:");
        Console.WriteLine("-----------------------");

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.PackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine("Total Cost:");
        Console.WriteLine(order.TotalCost());

        Console.WriteLine("-----------------------\n");
    }
}

}
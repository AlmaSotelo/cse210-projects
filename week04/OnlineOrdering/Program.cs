using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        //creates at least two orders with a 2-3 products each
        // Order #1
        Console.WriteLine("Order 1:\n");

        //note: since object order, needs the customer, and the customer needs address, lets instantiate for the address first, then customer, then orden. Then for each product
        Address address1 = new Address("2028 White Pine St", "Phoenix", "AZ", "USA");
        Customer customer1 = new Customer("Jhon Smith", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Gardening Tools 9-pieces", "GT-833R", 36.99, 1);
        Product product2 = new Product("Plastic T_Type Tags", "GA-503M", 5.99, 4);
        Product product3 = new Product("Burpee Wildflower 1 Gal", "G3-219A", 7.97, 2);
        //add each product to the list of products of Order
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        //Call the methods to get... 
        //...the packing label,...
        Console.WriteLine(order1.MakePackingLabel());
        //...the shipping label...
        Console.WriteLine(order1.MakeShippingLabel());
        //...and the total price of the order.
        Console.WriteLine($"\nTotal Price: ${order1.TotalPrice()}\n");

        // Order #2
        Console.WriteLine("\nOrder 2:\n");

        Address address2 = new Address("3007 Verdaguer", "Santa Coloma", "Barcelona", "Spain");
        Customer customer2 = new Customer("Pedro Sanchez", address2);

        Order order2 = new Order(customer2);

        Product product4 = new Product("Serrano Ham 5 lb", "F4-440G", 79.98, 2);
        Product product5 = new Product("Iberico de Bellota Ham", "F4-408N", 22.44, 5);
        Product product6 = new Product("Spanish cheese by Fermin", "F6-660M", 54.99, 1);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine(order2.MakePackingLabel());
        Console.WriteLine(order2.MakeShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.TotalPrice():F2}\n");
    }
}


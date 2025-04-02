using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating addresses

        Address address1 = new Address("123 Main St", "New York", "NY", "United States");
        Address address2 = new Address("456 Maple Ave", "Toronto", "On", "Canada");

        //Creating customers

        Customer customer1 = new Customer("Bryan Vasquez", address1);
        Customer customer2 = new Customer("John Doe", address2);


        //Creating Orders
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        //Adding products to the order
        order1.AddProduct(new Product("Laptop", "A123", 500, 2));
        order1.AddProduct(new Product("Desktop", "D342", 432.32, 1));

        order2.AddProduct(new Product("Tv", "A123", 599, 2));
        order2.AddProduct(new Product("PlayStation 5", "D342", 534.32, 1));

        //Displaying Results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.OrderTotalCost()}");

        Console.WriteLine("\n---------------------------------\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.OrderTotalCost()}");







    }
}
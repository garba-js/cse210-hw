using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // ORDER 1: Customer living in the USA

        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "New York",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        // Create products for order 1
        Product product1 = new Product("Laptop", "P001", 850.00, 1);
        Product product2 = new Product("Wireless Mouse", "P002", 25.00, 2);
        Product product3 = new Product("Keyboard", "P003", 45.00, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // ORDER 2: Customer living in Nigeria

        Address address2 = new Address(
            "15 Ahmadu Bello Way",
            "Jos",
            "Plateau State",
            "Nigeria"
        );

        Customer customer2 = new Customer("Garba Joseph", address2);

        Order order2 = new Order(customer2);

        // Create products for order 2
        Product product4 = new Product("Running Shoes", "P004", 65.00, 2);
        Product product5 = new Product("Travel Backpack", "P005", 40.00, 1);
        Product product6 = new Product("Wrist Watch", "P006", 55.00, 1);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        // DISPLAY ORDER 1

        Console.WriteLine("\n========================================");
        Console.WriteLine("             ORDER 1 DETAILS");
        Console.WriteLine("========================================");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Order Cost: ${order1.CalculateTotalCost():F2}");


        // DISPLAY ORDER 2

        Console.WriteLine("\n========================================");
        Console.WriteLine("             ORDER 2 DETAILS");
        Console.WriteLine("========================================");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Order Cost: ${order2.CalculateTotalCost():F2}");


        Console.WriteLine("\n========================================");
        Console.WriteLine("          END OF ORDER SUMMARY");
        Console.WriteLine("========================================");
    }
}
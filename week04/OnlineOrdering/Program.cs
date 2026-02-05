using System;

class Program
{
    static void Main()
    {
        // -------- ORDER 1 (USA) --------
        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "Texas",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P200", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P300", 45, 1));

        DisplayOrder(order1);


        // -------- ORDER 2 (International) --------
        Address address2 = new Address(
            "45 Market Road",
            "Nairobi",
            "Nairobi County",
            "Kenya"
        );

        Customer customer2 = new Customer("Kelvine Inganga", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P400", 300, 1));
        order2.AddProduct(new Product("Headphones", "P500", 60, 1));

        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order.GetTotalPrice()}");
        Console.WriteLine("---------------------------------\n");
    }
}

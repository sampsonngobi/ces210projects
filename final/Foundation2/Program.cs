using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Creat addresses
        Address address1 = new Address("123 Main St.", "Anytown", "CA");
        Address address2 = new Address("456 Other St.", "Anothertown","USA");

        // Create customers 
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Doe", address2);

        //creat products 
        Product product1 = new Product("AKG MIC","P001", 20.99, 5);
        Product product2 = new Product("Shure MIC","P002", 30.99,7);
        Product product3 = new Product("Sennheiser MIC","P003", 40.0, 10);
        Product product4 = new Product("Rode MIC","P004", 50.0, 13);


        // creat orders
        Order order1 = new Order(customer1);
        order1.Addproduct(product1);
        order1.Addproduct(product3);

        Order order2 = new Order(customer1);
        order2.Addproduct(product2);
        order2.Addproduct(product4);
        order2.Addproduct(product1);


        //Display order details 
        Console.WriteLine("Order 1 ");
        Console.WriteLine("Parking Label");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine();

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.ShippingLabel());

        Console.WriteLine("TOTAL PRICE");
        Console.WriteLine(order1.GetTotalCost());
        Console.WriteLine("-----------------------------");


        Console.WriteLine("Order 2 ");
        Console.WriteLine("Parking Label");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine();

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.ShippingLabel());

        Console.WriteLine("TOTAL PRICE");
        Console.WriteLine(order2.GetTotalCost());
        


        

    }
}
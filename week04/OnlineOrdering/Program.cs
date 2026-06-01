using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ONLINE ORDERING\n");

       
        Address addressUSA = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customerUSA = new Customer("Clarice Johnson", addressUSA);

        
        List<Product> productsOrder1 = new List<Product>()
        {
            new Product("Wireless Mouse", "M102", 28.6, 2),
            new Product("Keyboard", "K552", 45.00, 1)
        }; 

        Order order1 = new Order(productsOrder1, customerUSA);
        order1.DisplayOrderDetails();


       
    
        Address addressInt = new Address("Av. José Bonifácio 456", "Campinas", "SP", "Brazil");
        Customer customerInt = new Customer("Bruno da Silva", addressInt);

        
        List<Product> productsOrder2 = new List<Product>()
        {
            new Product("Laptop Stand", "S881", 19.99, 1),
            new Product("USB-C Cable", "H320", 34.99, 2),      
            new Product("HDMI Cable", "C012", 8.50, 3)         
        }; 

        
        Order order2 = new Order(productsOrder2, customerInt);
        order2.DisplayOrderDetails();
    }
}
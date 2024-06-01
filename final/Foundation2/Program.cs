using System;

class Program
{
    static void Main(string[] args)
    {

        //first scenario
        Address address1 = new Address("13th Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("Buju Benson", address1);
        Product flowers = new Product("Flowers", 22141, 20, 4);
        Product hangers = new Product("Hangers", 22142, 15, 2);
        Product shoes = new Product("Shoes", 22143, 200, 2);
        Order order1 = new Order(customer1);
        order1.AddProduct(flowers);
        order1.AddProduct(hangers);
        order1.AddProduct(shoes);        


        //second scenario
        Address address2 = new Address("6 gbemi street", "Accra", "GH", "Ghana");
        Customer customer2 = new Customer("Michael Saka", address2);
        Product SummerShirt = new Product("Summer shirt", 22144, 50, 5);
        Product Jeans = new Product("Chinos Jeans", 22145, 120, 2);
        Product watch = new Product("Rolex watch", 22146, 500, 3);        
        Order order2 = new Order(customer2);
        order2.AddProduct(SummerShirt);
        order2.AddProduct(Jeans);
        order2.AddProduct(watch);

        //third scenario
        Address address3 = new Address("75012 Paris Cedex 14", "Paris", "FR", "France");
        Customer customer3 = new Customer("Kylian Mpape", address3);
        Product jersey = new Product("Paris Home Jersey", 22147, 150, 1);
        Product ShinGuard = new Product("Shin Guard ", 22148, 200, 2);        
        Order order3 = new Order(customer3);
        order3.AddProduct(jersey);
        order3.AddProduct(ShinGuard);  

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);
        foreach (Order ords in orders)
        {
            ords.DisplayShippingLabel();
            ords.DisplayPackingLabel();
            ords.DisplayTotalCostOfOrder();
        }      
    }
}
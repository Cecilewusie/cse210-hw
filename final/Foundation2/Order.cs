public class Order
{
    private List<Product> _product = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    private double CalculateTotalCostOfOrder()
    {
        double orderCost = 0;
        foreach (Product p in _product)
        {
            orderCost = orderCost + p.CalculateTotalCost();
        }
        return orderCost+=_customer.IsInUSA()? 5 : 35;
    }

    private List<string> GeneratePackingLabel()
    {
        List<string> packing = new List<string>();
        foreach (Product product in _product)
        {
            packing.Add(product.ProductNameWithId());
        }
        return packing;

    }

    private string GenerateShippingLabel()
    {
        return _customer.CustomerWithAddress();
    }

    public void DisplayTotalCostOfOrder()
    {
        Console.WriteLine();
        Console.WriteLine("-----Total cost of Order------");
        Console.WriteLine($"Your Total order is : ${CalculateTotalCostOfOrder()}");
        Console.WriteLine();
        Console.WriteLine(">> Thanks for shopping with us <<");
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine();
        Console.WriteLine("------Shipping Label-----");
        Console.WriteLine(GenerateShippingLabel());
    }
    
    public void DisplayPackingLabel()
    {
        Console.WriteLine();
        Console.WriteLine("------Packing Lable------");
        foreach (string L in GeneratePackingLabel())
        {
            Console.WriteLine(L);
        }
    }
} 
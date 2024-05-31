public class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string productName, int productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }

    public string ProductNameWithId()
    {
        return $"Product Name: {_productName} \nProduct Id: {_productId}";
    }
}
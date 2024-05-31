public class Customer
{
    private string _customerName;
    private Address _Address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _Address = address;
    }

    public bool IsInUSA()
    {
        return _Address.IsInUSA();
    }

    public string CustomerWithAddress()
    {
        return $"Customer Name: {_customerName} \nCustomer Address: {_Address.GetFullAddress()}";
    }
}
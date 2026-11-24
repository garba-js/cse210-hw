public class Customer
{
    // Private member variables
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Check whether the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Return the customer's name
    public string GetName()
    {
        return _name;
    }

    // Return the customer's formatted address
    public string GetAddressString()
    {
        return _address.GetFormattedAddress();
    }
}
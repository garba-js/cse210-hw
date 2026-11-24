public class Product
{
    // Private member variables
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Calculate the total cost of the product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Return the product name
    public string GetName()
    {
        return _name;
    }

    // Return the product ID
    public string GetProductId()
    {
        return _productId;
    }
}
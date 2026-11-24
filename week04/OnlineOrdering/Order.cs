using System.Collections.Generic;
using System.Text;

public class Order
{
    // Private member variables
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate the total order cost including shipping
    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            totalCost += 5.00;
        }
        else
        {
            totalCost += 35.00;
        }

        return totalCost;
    }

    // Generate the packing label
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();

        label.AppendLine("PACKING LABEL");

        foreach (Product product in _products)
        {
            label.AppendLine(
                $"{product.GetName()} - ID: {product.GetProductId()}"
            );
        }

        return label.ToString();
    }

    // Generate the shipping label
    public string GetShippingLabel()
    {
        StringBuilder label = new StringBuilder();

        label.AppendLine("SHIPPING LABEL");
        label.AppendLine(_customer.GetName());
        label.AppendLine(_customer.GetAddressString());

        return label.ToString();
    }
}
using System;
using System.Collections.Generic;

public class Order
{
    protected List<Product> _products;
    protected Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double totalCost = _customer.LivesInUSA() ? 5 : 35;
        foreach (var product in _products)
        {
            totalCost += product.GetPrice();
        }
        return totalCost;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

}

using System;
using System.Collections.Generic;
using System.Reflection.Emit;

public class Order 
{

    List<Product> _products;
    private Customer _customer;


    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void Addproduct(Product product)
    {   
        _products = new List<Product>();
        _products.Add(product);
    }


    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        double shipppingCost = 0;

        if (_customer.LivesInUsa())
        {
            shipppingCost = 5;
        }
        else
        {
            shipppingCost = 35;
        }

        return total + shipppingCost;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach(Product product in _products)
        {
            label = product.GetParkingLabel();
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddess}";
    }


}
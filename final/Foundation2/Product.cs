using System;
using System.Collections.Generic;

public class Product
{
    private string _productName;
    private string _productId;
    private double _productPrice;

    private int _productQuanty; 

    public  Product(string productName, string productId, double productPrice, int productQuanty)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuanty = productQuanty;
    }

    public string GetproductName()
    {
        return _productName;
    }

    public string GetproductId()
    {
        return _productId;
    }

    public double GetproductPrice()
    {
        return _productPrice;
    }

    public int GetProductQuanty()
    {
        return _productQuanty;
    }

    public double TotalCost()
    {
        return _productPrice * _productQuanty;
    }
    
    public string GetParkingLabel()
    {
        return $"{_productName} + {_productId}";
    }
}
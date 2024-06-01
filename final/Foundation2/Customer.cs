using System;
using System.Collections.Generic;

public class Customer
{
    private string _customerName;
    private Address _address;
    

   public Customer(string name, Address address)
   {
    _customerName = name;
    _address = address;
    
   }

   public string GetName()
   {
    return _customerName;
   }

   public Address GetAddress()
   {
    return _address;
   }

   public bool LivesInUsa()
   {
        return _address.IsAmerican();
   }

}
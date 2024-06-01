using System;
using System.Collections.Generic;

public class Address
{
    private string _city;
    private string _state;
    private string _country;


    public Address(string city, string state, string country)
    {
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetCity(string city)
    {
        return _city;
    }

    public string GetState(string state)
    {
        return _city;
    }

    public string GetCountry(string country)
    {
        return _country;
    }
    
    public bool IsAmerican()
    {
        if(_country == "USA")
        {
            return true;
        }
      

        else 
        {
            return false;
        }
       
    }

    public string GetFullAddess()
    {
        return $"{_city}, {_state}, {_country}";
    }
   

}
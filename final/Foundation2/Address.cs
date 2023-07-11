using System;
using System.Collections.Generic;
public class Address
{
    protected string _street;
    protected string _city;
    protected string _state;
    protected string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
    return $"{_street}\n{_city}\n{_state}\n{_country}";
    }

}
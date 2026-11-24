using System;

public class Address
{
    // Private member variables
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Constructor
    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // Check whether the address is in the USA
    public bool IsInUSA()
    {
        return string.Equals(
            _country,
            "USA",
            StringComparison.OrdinalIgnoreCase
        );
    }

    // Return the complete formatted address
    public string GetFormattedAddress()
    {
        return $"{_street}\n{_city}\n{_stateOrProvince}\n{_country}";
    }
}
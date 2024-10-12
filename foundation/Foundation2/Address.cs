public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool AmericanOrNot()
    {
        return (_country == "USA")? true : false;
    }

    public string DisplayAddress()
    {
        string address = $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        return address;
    }

}

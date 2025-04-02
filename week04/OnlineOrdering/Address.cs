class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    //Constructor

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    //Setters

    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;

    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }


    //Getters

    public string GetCountry()
    {
        return _country;
    }

    //Methods

    public bool LivesInUsa()
    {
        return _country == "United States" || _country == "USA";
    }

    public override string ToString()
    {
        return $"Street Address: {_streetAddress} \n City: {_city} \n State or Province: {_stateProvince} \n Country: {_country}";
    }
}
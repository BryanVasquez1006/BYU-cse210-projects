class Customer 
{
    private string _name;
    private Address _address;

    //Constructor

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //setters

    public void SetCustomerName(string name)
    {
        _name = name;
    }

    public void SetCustomerAddress(Address address)
    {
        _address = address;
    }

    //Space for getters

    public string GetCustomerName()
    {
        return _name;
    }

    public Address GetCustomerAddress()
    {
        return _address;
    }

    //Methods

    public bool LivesInUsa()
    {
       if (_address.GetCountry() == "United States" || _address.GetCountry() == "USA")
       {
        return _address.LivesInUsa();
       }

       return false;

    }


}
class Product 
{
    private string _productName;
    private string _productId;
    private double _productPrice;
    private int _productQuantity;

    //Declaring constructor

    public Product(string productName, string productId, double productPrice, int productQuantity)

    {
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
        _productName = productName;
    }


    //Declaring setters

    public void SetProductId( string productId)
    {
        _productId = productId;
    }

    public void SetProductName(string productName)
    {
        _productName = productName;
    }

    public void SetProductPrice(double productPrice)
    {
        _productPrice = productPrice;
    }

    public void SetProductQuantity(int productQuantity)
    {
        _productQuantity = productQuantity;
    }

    //Space for the getters

    public int GetProductQuantity()
    {
        return _productQuantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    //Methods

    public double TotalProductCost()
    {
        double total = _productPrice * _productQuantity;

        return total;
    } 

}
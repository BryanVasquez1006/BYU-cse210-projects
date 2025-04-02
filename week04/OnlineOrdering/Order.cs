using System.Numerics;

class Order 
{
    private List<Product> _products;
    private Customer _customer;
    private double _orderTotal;
    private string _packingLabel;
    private string _shippingLabel;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;

    }

    //setting up setters

    public void SetOrderTotal(double orderTotal)
    {
        _orderTotal = orderTotal;
    }
    
    public void SetPackingLabel(string packingLabel)
    {
        _packingLabel = packingLabel;
    }

    public void SetShippingLabel(string shippingLabel)
    {
        _shippingLabel = shippingLabel;
    }

    //Getters Space




    //Methods

    public double OrderTotalCost()
    {

         double total = 0;

        foreach (Product product in _products)
        {
            total = total + product.TotalProductCost();
        }

        double shippingCost = 5;

        if (_customer.LivesInUsa() != true)
        {
            shippingCost = 35;
        }

        total = total + shippingCost;
        return Math.Round(total, 2);
        
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label: \n";

        foreach (Product product in _products)
        {
            packingLabel += $"Product Name: {product.GetProductName()}\n Product ID: {product.GetProductId()} \n";
        }

        return packingLabel;

    }

    public string GetShippingLabel()
    {
        return $"Customer Name: {_customer.GetCustomerName()} \n Customer Address: {_customer.GetCustomerAddress()}\n";

    }



}
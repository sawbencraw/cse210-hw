public class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double GetTotalPrice()
    {
        double totalPrice = products.Sum(product => product.GetTotalCost());
        if (customer.IsUSACustomer())
        {
            totalPrice += 5; // Shipping cost for USA
        }
        else
        {
            totalPrice += 35; // Shipping cost for non-USA
        }
        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Name: {customer.GetName()}\nAddress:\n{customer.GetAddress()}";
    }
}
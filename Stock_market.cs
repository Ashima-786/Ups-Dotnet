using System;
class Product
{
    private string productId;
    private string productName;
    private int stockQuantity;
    private double price;
    public Product(string id, string name, int stock, double price)
    {
        productId = id;
        productName = name;
        stockQuantity = stock;
        this.price = price;
    }
    public void AddStock(int quantity)
    {
        if (quantity > 0)
            stockQuantity += quantity;
        else
            Console.WriteLine("Invalid stock!");
    }
    public void RemoveStock(int quantity)
    {
        if (quantity > 0 && quantity <= stockQuantity)
            stockQuantity -= quantity;
        else
            Console.WriteLine("Insufficient stock!");
    }
    public double CalculateStockValue()
    {
        return stockQuantity * price;
    }
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product: " + productName);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Initial Stock: 10");
        Console.WriteLine("Added Stock: 5");
        Console.WriteLine("Removed Stock: 3");
        Console.WriteLine("Available Stock: " + stockQuantity);
        Console.WriteLine("Total Stock Value: " + CalculateStockValue());
    }
}
public class Stock_market
{
    public static void Main(string[] args)
    {
        Product p = new Product("P101", "Laptop", 10, 50000);
        p.AddStock(5);
        p.RemoveStock(3);
        p.DisplayProductDetails();
    }
}

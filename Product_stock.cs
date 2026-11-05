using System;

class Product
{
    private string productId;
    private string productName;
    private int stockQuantity;
    private double price;
    public string ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }

    public double Price
    {
        get { return price; }
        set 
        { 
            if (value > 0)
            {
                price = value; 
            }
            else
            {
                Console.WriteLine("Error: Product price must be greater than zero.");
            }
        }
    }
    public int StockQuantity
    {
        get { return stockQuantity; }
    }
    public Product(string productId, string productName, int initialStock, double initialPrice)
    {
        this.productId = productId;
        this.productName = productName;
        
        if (initialStock >= 0)
        {
            this.stockQuantity = initialStock;
        }
        else
        {
            this.stockQuantity = 0;
        }

        if (initialPrice > 0)
        {
            this.price = initialPrice;
        }
        else
        {
            this.price = 1;
        }
    }
    public void AddStock(int quantity)
    {
        if (quantity > 0)
        {
            stockQuantity += quantity;
        }
        else
        {
            Console.WriteLine("Error: Stock addition must be positive.");
        }
    }

    public void RemoveStock(int quantity)
    {
        if (quantity > stockQuantity)
        {
            Console.WriteLine("Error: Cannot remove more bsz your stock is less sorry:)");
        }
        else if (quantity <= 0)
        {
            Console.WriteLine("Error: Stock removal went negative do check your number.");
        }
        else
        {
            stockQuantity -= quantity;
        }
    }

    public double CalculateStockValue()
    {
        return stockQuantity * price;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product: " + productName);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Available Stock: " + stockQuantity);
        Console.WriteLine("Total Stock Value: " + CalculateStockValue());
    }
}

public class Product_stock
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Product ID: ");
        string id = Console.ReadLine();
        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Initial Stock: ");
        int initialStock = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Product prod = new Product(id, name, initialStock, price);
        Console.Write("Enter Stock to Add: ");
        int toAdd = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Stock to Remove: ");
        int toRemove = Convert.ToInt32(Console.ReadLine());
        prod.AddStock(toAdd);
        prod.RemoveStock(toRemove);
        Console.WriteLine(" Output");
        Console.WriteLine("Product: " + prod.ProductName);
        Console.WriteLine("Price: " + prod.Price);
        Console.WriteLine("Initial Stock: " + initialStock);
        Console.WriteLine("Added Stock: " + toAdd);
        Console.WriteLine("Removed Stock: " + toRemove);
        Console.WriteLine("Available Stock: " + prod.StockQuantity);
        Console.WriteLine("Total Stock Value: " + prod.CalculateStockValue());
    }
}

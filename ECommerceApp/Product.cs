using System.Collections.Generic;
using System.Linq;

namespace ECommerceApp;

public class Product
{
    public int ProductNumber { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }
    public int StockQuantity { get; set; }
    public string Category { get; set; }
    public List<string> Images { get; set; } = new List<string>();
    public List<Review> Reviews { get; set; } = new List<Review>();

    // A dummy database to store all products 
    private static List<Product> _products = new List<Product>();

    public bool AddProduct()
    {
        // The new product name already exists return false
        if (_products.Any(p => p.Name == Name))
        {
            return false;
        }

        // If the price is less than or equal to 0 return false
        if (Price <= 0)
        {
            return false;
        }

        // If the stock quantity is less than 1
        if (StockQuantity < 1) {
            return false;
        }

        // Add the product to the "database"
        _products.Add(this);
        return true;
    }

    public bool RemoveProduct(int productNumber)
    {
        // Get the product to remove using it's product number:
        Product? productToRemove = _products.FirstOrDefault(p => p.ProductNumber == productNumber);
        
        // If the product does not exist return false
        if (productToRemove == null)
        {
            return false;
        }

        // Delete the product:
        _products.Remove(productToRemove);
        return true;
    }

    public bool UpdateStock(int productNumber, int newStockQuantity)
    {
        // Get the product using it's product number:
        Product? productToUpdate = _products.FirstOrDefault(p => p.ProductNumber == productNumber);

        // If the product does not exist return false
        if (productToUpdate == null)
        {
            return false;
        }

        // Update the stock quantity
        productToUpdate.StockQuantity = newStockQuantity;
        return true;
    }

    public static void Main ()
    {
        
    }
}

public class Review { }
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECommerceApp;

namespace ECommerceTests;

[TestClass]
public class ProductTests
{
    [TestMethod]
    public void AddProduct_UniqueProductName_ReturnsTrue()
    {
        Product product = new Product
        {
            Name = "Winter coat",
            Price = 100.00m,
            Description = "Warm winter coat",
            StockQuantity = 10,
            Color = "Black",
            Size = "Large",
            Category = "Coats",
            ProductNumber = 1
        };
        Assert.IsTrue(product.AddProduct());
    }

    [TestMethod]
    public void AddProduct_DuplicateProductName_ReturnsTrueThenFalse()
    {
        Product product1 = new Product
        {
            Name = "Summer Dress",
            Price = 50.00m,
            Description = "Light summer dress",
            StockQuantity = 20,
            Color = "Yellow",
            Size = "Medium",
            Category = "Dresses",
            ProductNumber = 2
        };
        Assert.IsTrue(product1.AddProduct());

        Product product2 = new Product
        {
            Name = "Summer Dress",
            Price = 50.00m,
            Description = "Light summer dress",
            StockQuantity = 20,
            Color = "Yellow",
            Size = "Medium",
            Category = "Dresses",
            ProductNumber = 3
        };
        Assert.IsFalse(product2.AddProduct());
    }

    [TestMethod]
    public void AddProduct_NegativePrice_ReturnsFalse()
    {
        Product product = new Product
        {
            Name = "Windbreaker",
            Price = -0.01m,
            Description = "Waterproof windbreaker",
            StockQuantity = 5,
            Color = "Blue",
            Size = "Large",
            Category = "Jackets",
            ProductNumber = 4
        };
        Assert.IsFalse(product.AddProduct());
    }

    [TestMethod]
    public void AddProduct_ZeroPrice_ReturnsFalse()
    {
        Product product = new Product
        {
            Name = "Hi vis vest",
            Price = 0.00m,
            Description = "High visibility safety vest",
            StockQuantity = 30,
            Color = "Yellow",
            Size = "One Size",
            Category = "Safety",
            ProductNumber = 5
        };
        Assert.IsFalse(product.AddProduct());
    }

    [TestMethod]
    public void AddProduct_ValidPositivePrice_ReturnsTrue()
    {
        Product product = new Product
        {
            Name = "Shorts",
            Price = 0.01m,
            Description = "Comfortable shorts",
            StockQuantity = 15,
            Color = "Khaki",
            Size = "Small",
            Category = "Shorts",
            ProductNumber = 6
        };
        Assert.IsTrue(product.AddProduct());
    }

    [TestMethod]
    public void AddProduct_LargePositivePrice_ReturnsTrue()
    {
        Product product = new Product
        {
            Name = "Blazers",
            Price = 1000000.00m,
            Description = "Formal blazer",
            StockQuantity = 2,
            Color = "Navy",
            Size = "Medium",
            Category = "Formalwear",
            ProductNumber = 7
        };
        Assert.IsTrue(product.AddProduct());
    }
}
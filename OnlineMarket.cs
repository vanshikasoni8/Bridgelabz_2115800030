using System;
using System.Collections.Generic;

// Abstract base class for product categories
abstract class ProductCategory
{
    public string CategoryName { get; set; }
    protected ProductCategory(string categoryName)
    {
        CategoryName = categoryName;
    }
}

class BookCategory : ProductCategory
{
    public BookCategory() : base("Books") { }
}

class ClothingCategory : ProductCategory
{
    public ClothingCategory() : base("Clothing") { }
}

// Generic Product class restricted to ProductCategory
class Product<T> where T : ProductCategory
{
    public string Name { get; set; }
    public double Price { get; set; }
    public T Category { get; set; }

    public Product(string name, double price, T category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public void Display()
    {
        Console.WriteLine($"Product: {Name}, Category: {Category.CategoryName}, Price: ${Price}");
    }
}

// Generic method to apply discount
static class DiscountHelper
{
    public static void ApplyDiscount<T>(T product, double percentage) where T : Product<ProductCategory>
    {
        product.Price -= product.Price * (percentage / 100);
        Console.WriteLine($"Discount applied! New price of {product.Name}: ${product.Price:F2}");
    }
}

class Program
{
    static void Main()
    {
        Product<BookCategory> book = new Product<BookCategory>("C# Programming", 50, new BookCategory());
        Product<ClothingCategory> shirt = new Product<ClothingCategory>("T-Shirt", 20, new ClothingCategory());

        List<Product<ProductCategory>> catalog = new List<Product<ProductCategory>> { book, shirt };

        Console.WriteLine("\nProduct Catalog:");
        foreach (var product in catalog)
        {
            product.Display();
        }

        // Apply discount
        Console.WriteLine("\nApplying Discounts:");
        DiscountHelper.ApplyDiscount(book, 10);
        DiscountHelper.ApplyDiscount(shirt, 15);
    }
}


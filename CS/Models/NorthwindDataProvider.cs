using System.Collections;
using System.Collections.Generic;

public class NorthwindDataProvider {
    public static IEnumerable GetCategories() {
        List<Category> categories = new List<Category>();

        categories.Add(new Category() { CategoryID = 1, CategoryName = "Beverages" });
        categories.Add(new Category() { CategoryID = 2, CategoryName = "Condiments" });
        categories.Add(new Category() { CategoryID = 3, CategoryName = "Confections" });
        categories.Add(new Category() { CategoryID = 4, CategoryName = "Dairy Products" });
        categories.Add(new Category() { CategoryID = 5, CategoryName = "Grains/Cereals" });
        categories.Add(new Category() { CategoryID = 6, CategoryName = "Meat/Poultry" });
        categories.Add(new Category() { CategoryID = 7, CategoryName = "Produce" });
        categories.Add(new Category() { CategoryID = 8, CategoryName = "Seafood" });

        return categories;
    }
    
    public static IEnumerable GetProducts() {
        List<Product> products = new List<Product>();

        products.Add(new Product() { ProductID = 1, ProductName = "Chai", UnitPrice = 19, UnitsOnOrder = 0 });
        products.Add(new Product() { ProductID = 2, ProductName = "Chang", UnitPrice = 19, UnitsOnOrder = 40 });
        products.Add(new Product() { ProductID = 3, ProductName = "Aniseed Syrup", UnitPrice = 10, UnitsOnOrder = 70 });
        products.Add(new Product() { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", UnitPrice = 22, UnitsOnOrder = 0 });
        products.Add(new Product() { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", UnitPrice = 21.35m, UnitsOnOrder = 0 });
        products.Add(new Product() { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", UnitPrice = 25, UnitsOnOrder = 0 });

        return products;
    }
}
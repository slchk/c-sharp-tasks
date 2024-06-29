// Создайте Dictionary, содержащий пары значений  - имя продукта и количестов единиц продукта (класс Product).
// Перебрать и распечатать пары значений в формате "Name = abc, Price = 15, Count = 5"
// Перебрать и распечатать набор из имен продуктов
// Перебрать и распечатать значения количества единиц продуктов.
// Для каждого перебора создать свой метод.
using System;
using System.Reflection;
using task_6_2;

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product
            {
                Name = "Milk",
                Price = 300,
                ProductionDate = new DateTime(2023, 1, 1),
                ExpirationDate = new DateTime(2025, 1, 1)
            },
            new Product
            {
                Name = "Sugar",
                Price = 200,
                ProductionDate = new DateTime(2023, 2, 1),
                ExpirationDate = new DateTime(2026, 2, 1)
            },
            new Product
            {
                Name = "Chocolate",
                Price = 400,
                ProductionDate = new DateTime(2023, 2, 1),
                ExpirationDate = new DateTime(2024, 10, 15)
            },
            new Product
            {
                Name = "Cereal",
                Price = 301,
                ProductionDate = new DateTime(2024, 2, 8),
                ExpirationDate = new DateTime(2024, 11, 29) 
            }
        };
        
        var productQuantities = new Dictionary<string, int>()
        {
            { "Milk", 10},
            { "Sugar", 25},
            { "Chocolate", 12},
            { "Cereal", 4},
        };
        
        CheckName(productQuantities);
        CheckQuantity(productQuantities);
        CheckPrice(productQuantities, products);
    }
    
    static void CheckName(Dictionary<string, int> productQuantities) 
    {
        foreach (var product in productQuantities)
        {
            Console.WriteLine($"The product name is: {product.Key}");
        }
    }
    
    static void CheckQuantity(Dictionary<string, int> productQuantities) 
    {
        foreach (var product in productQuantities)
        {
            Console.WriteLine($"There are {product.Value} packs of {product.Key}");
        }
    }
    
    static void CheckPrice(Dictionary<string, int> productQuantities, List<Product> products) 
    {
        foreach (var product in productQuantities)
        {
            foreach (var item in products)
            {
                if (product.Key == item.Name)
                {
                    Console.WriteLine($"There are {product.Value} packs of {product.Key} cost {item.Price}");
                }
            }
        }
    }
}

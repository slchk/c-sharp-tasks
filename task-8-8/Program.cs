// Задание 5a:
// На основе задания 4 необходимо написать преобразование Dictionary в List.

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
        
        var newList = productQuantities.ToList();
        foreach (var kvp in newList)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        
        CheckName(productQuantities);
        CheckQuantity(productQuantities);
        CheckPrice(productQuantities, products);
    }
    
    static void CheckName(Dictionary<string, int> newList) 
    {
        foreach (var product in newList)
        {
            Console.WriteLine($"The product name is: {product.Key}");
        }
    }
    
    static void CheckQuantity(Dictionary<string, int> newList) 
    {
        foreach (var product in newList)
        {
            Console.WriteLine($"There are {product.Value} packs of {product.Key}");
        }
    }
    
    static void CheckPrice(Dictionary<string, int> newList, List<Product> products) 
    {
        foreach (var product in newList)
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
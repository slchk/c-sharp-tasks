// Задание 3:
// Создать коллекцию, содержащую объекты Product. Написать метод, который перебирает элементы коллекции и проверяет цену продуктов.
// Если цена продукта больше 300 рублей, продукт перемещается в другую коллекцию.
// Необходимо вывести минимальное значение продукта из полученной коллекции.
using System;
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
        var minPrice = products.Min(p => p.Price);
        Console.WriteLine($"The minimum price is: {minPrice}");
        
        CheckPrice(products);
        
        Console.WriteLine("\nRemaining Products:");
        foreach (var product in products)
        {
            product.DisplayInfo();
        }
    }
    
    static void CheckPrice(List<Product> products) 
    {
        List<Product> itemsToRemove = new List<Product>();
        foreach (var product in products)
        {
            if (product.Price > 300)
            {
                itemsToRemove.Add(product);
            }
            else
            {
                product.DisplayInfo();
            }
        }
        foreach (var item in itemsToRemove)
        {
            products.Remove(item);
        }
    }
}


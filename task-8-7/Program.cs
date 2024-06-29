// Задание 5b:
// На основе задания 3 необходимо написать преобразование List в Dictionary.

using task_6_2;

class Program
{
    static void Main()
    {
        var products = new Dictionary<string, Product>()
        {
            {"Milk", new Product 
                {
                Name = "Milk",
                Price = 300,
                ProductionDate = new DateTime(2023, 1, 1),
                ExpirationDate = new DateTime(2025, 1, 1)
                }
            },
            {"Sugar",new Product 
                {
                Name = "Sugar",
                Price = 200,
                ProductionDate = new DateTime(2023, 2, 1),
                ExpirationDate = new DateTime(2026, 2, 1)
                }
            },
            {"Chocolate",new Product 
                {
                Name = "Chocolate",
                Price = 400,
                ProductionDate = new DateTime(2023, 2, 1),
                ExpirationDate = new DateTime(2024, 10, 15)
                }
            },
            {"Cereal", new Product 
                {
                Name = "Cereal",
                Price = 301,
                ProductionDate = new DateTime(2024, 2, 8),
                ExpirationDate = new DateTime(2024, 11, 29) 
                }
            }
        };
        
        var minPrice = products.Min(p => p.Value.Price);
        Console.WriteLine($"The minimum price is: {minPrice}");
        
        CheckPrice(products);
        
        Console.WriteLine("\nRemaining Products:");
        foreach (var product in products)
        {
            product.Value.DisplayInfo();
        }
    }
    
    static void CheckPrice(Dictionary<string, Product> products) 
    {
        List<Product> itemsToRemove = new List<Product>();
        foreach (var product in products)
        {
            if (product.Value.Price > 300)
            {
                itemsToRemove.Add(product.Value);
            }
            else
            {
                product.Value.DisplayInfo();
            }
        }
        foreach (var item in itemsToRemove)
        {
            products.Remove(item.Name);
        }
    }
}

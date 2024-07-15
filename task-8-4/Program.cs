// Задание 2:
// Создать SortedSet содержащий объекты Product. Содержимое данной коллекции распечатать с помощью for each.
using task_6_2;

class Program
{
    static void Main()
    {
        SortedSet<Product> products = new SortedSet<Product>(new ProductComparer())
        {
            new Product
            {
                Name = "Milk",
                Price = 10.5,
                ProductionDate = new DateTime(2023, 1, 1),
                ExpirationDate = new DateTime(2025, 1, 1)
            },
            new Product
            {
                Name = "Sugar",
                Price = 2.40,
                ProductionDate = new DateTime(2023, 2, 1),
                ExpirationDate = new DateTime(2026, 2, 1)
            },
            new Product
            {
                Name = "Chocolate",
                Price = 1.20,
                ProductionDate = new DateTime(2023, 2, 1),
                ExpirationDate = new DateTime(2024, 10, 15)
            },
            new Product
            {
            Name = "Cereal",
            Price = 15.80,
            ProductionDate = new DateTime(2024, 2, 8),
            ExpirationDate = new DateTime(2024, 11, 29) 
            }
        };
        
        foreach (var product in products)
        {
            {
                product.DisplayInfo();
            };
        }
    }
}



// Задание 1:
// а) Создать динамический массив, содержащий объекты класса Product 
// б) Распечатать его содержимое используя for each. 
// в) Изменить цену одного продукта на 100. 
// г) Удалить последний продукт. 
// е) Получить массив содержащий продукты из коллекции тремя способами и вывести на консоль. 
// ж) Удалить все продукты.
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
        if (products.Count > 0)
        {
            products[0].Name = "Milk";
            products[0].Price += 100;
            products[0].ProductionDate = new DateTime(2023, 5, 1);
            products[0].ExpirationDate = new DateTime(2024, 5, 1);
        }
        
        products.RemoveAt(products.Count - 1);
        
        foreach (var product in products)
        {
            {
                product.DisplayInfo();
            };
        }
        
        // products.ForEach(product => product.DisplayInfo());

        // products.Select(product =>
        // {
        //     product.DisplayInfo();
        //     return product;
        // }).ToList();
        
        products.Clear();
    }
}

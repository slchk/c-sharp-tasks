// Полную структуру классов и их взаимосвязь продумать самостоятельно. Исходные данные база (массив) из n товаров задать непосредственно в коде (захардкодить).
// Создать базовый класс Product с методами, позволяющим вывести на экран информацию о товаре, а также определить, соответствует ли она сроку годности на текущую дату.
// Создать производные классы:
// Продукт (название, цена, дата производства, срок годности),
// Партия (название, цена, количество шт, дата производства, срок годности),
// Комплект (названия, цена, перечень продуктов) со своими методами вывода информации на экран, и определения соответствия сроку годности.
// Создать базу (массив) из n товаров, вывести полную информацию из базы на экран, а также организовать поиск просроченного товара (на момент текущей даты).

using System.Reflection.Metadata.Ecma335;

public class Product
{ 
    public string Name { get; set; }
    public double Price { get; set; }
    public DateTime ExpirationDate { get; set; }
    public DateTime ProductionDate { get; set; }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price}, Production Date: {ProductionDate}, Expiration Date: {ExpirationDate}");
    }
    
    public bool IsExpired()
    {
        return ExpirationDate <= DateTime.Today;
    }
}
class ProductItem : Product
{
    public int Amount { get; set; }
    
}
class Batch : Product
{
    public int Amount { get; set; }
    public void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Amount: {Amount}");
    }
}

class Set : Product
{
    public ProductItem[] Products { get; set; }

    public void DisplaySetInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Products in the Set:");
        foreach (var product in Products)
        {
            Console.WriteLine($" - {product.Name}, Amount: {product.Amount}");
        }
    }
}

class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new ProductItem
            {
                Name = "Milk", Price = 3.40, Amount = 1, ExpirationDate = new DateTime(2024, 6, 13),
                ProductionDate = DateTime.Today
            },
            new ProductItem
            {
                Name = "Sugar", Price = 2.40, Amount = 2, ExpirationDate = new DateTime(2025, 10, 13),
                ProductionDate = DateTime.Today
            },
            new Batch
            {
                Name = "Chocolate", Price = 1.20, Amount = 100, ExpirationDate = new DateTime(2024, 12, 15),
                ProductionDate = DateTime.Today
            },
            new Set
            {
                Name = "Breakfast Set", Price = 10.99,
                Products = new ProductItem[]
                {
                    new ProductItem
                    {
                        Name = "Cereal", Price = 3.99, Amount = 1, ExpirationDate = new DateTime(2024, 1, 1),
                        ProductionDate = DateTime.Today
                    },
                    new ProductItem
                    {
                        Name = "Milk", Price = 2.50, Amount = 1, ExpirationDate = new DateTime(2024, 1, 1),
                        ProductionDate = DateTime.Today
                    }
                }
            }
        };

        foreach (var product in products)
        {
            product.DisplayInfo();
        }

        foreach (var product in products)
        {
            if (product.IsExpired())
            {
                Console.WriteLine($"{product.Name} have expired");
            } ;
        }
    }
}

                
         
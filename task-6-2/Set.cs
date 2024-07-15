namespace task_6_2;

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
using System;

namespace task_6_2;

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


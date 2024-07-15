namespace task_6_2;

class Batch : Product
{
    public int Amount { get; set; }
    public void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Amount: {Amount}");
    }
}
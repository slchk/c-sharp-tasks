namespace task_9_3;

class Diesel : Engine
{
    public Diesel(int horsepower) : base("Diesel", horsepower)
    {
    }

    public override void Start()
    {
        Console.WriteLine($"Starting {Type} engine with {Horsepower} horsepower");
    }

    public override void Stop()
    {
        Console.WriteLine($"Stopping {Type} engine");
    }
}
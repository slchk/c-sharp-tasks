namespace task_9_3;

class Gasoline: Engine
{
    public Gasoline(int horsepower) : base("Gasoline", horsepower)
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
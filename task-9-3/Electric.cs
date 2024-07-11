namespace task_9_3;

class Electric: Engine
{
    public Electric(int horsepower) : base("Electro", horsepower)
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
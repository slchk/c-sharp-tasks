namespace task_9_3;

public abstract class Engine 
{ 
    public string Type { get; }
    public int Horsepower { get; }

    public Engine(string type, int horsepower) 
    {
        Type = type;
        Horsepower = horsepower;
    }

    public abstract void Start();
    public abstract void Stop();
}
    
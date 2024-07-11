using task_9_3;

class Program
{ 
    static void Main()
    { 
        Diesel diesel = new Diesel(200); 
        Car<Diesel> dieselCar = new Car<Diesel>("Audi Q7", diesel);
        diesel.Start(); 
        diesel.Stop();
    }
}


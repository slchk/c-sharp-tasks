// Реализовать класс машина у который будет поле  обобщенное двигатель.
// Создать иерархию наследования для двигателей (абстрактный, дизельный, бензиновый, електро).
// Сделать так чтобы создать автомобиль можно было только передавая туда один из типов двигателя.
// Реализовать методы для движения автомобиля.

namespace task_9_3;

public class Car<T> where T : Engine
{
    public string Model { get; set; }
    public T Engine { get; }

    public Car(string model, T engine)
    {
        Model = model;
        Engine = engine;
    }
    
    public void StartEngine()
    {
        Engine.Start();
    }
    
    public void StopEngine()
    {
        Engine.Stop();
    }
}

//Реализовать класс Point, который определяет точку на координатной плоскости. В классе реализовать:
//внутренние поля x, y; конструктор с 2 параметрами;
// свойства доступа к внутренним полям класса; // метод, выводящий значения внутренних полей класса.
namespace task_9_2;

struct Point
{
    private double X { get; }
    private double Y { get; }
    
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Point coordinates: x = {X}, y = {Y}");
    }
}

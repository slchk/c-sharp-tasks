// 1. Написать иерархию классов «Фигуры». Фигура -> Треугольник -> Прямоугольник -> Круг.
// Реализовать ф-ю подсчета площади для каждого типа фигуры и подсчет периметра.
// Создать массив из 5 фигур.Bывести на экран сумму периметра всех фигур в массиве.

using System.Drawing;
abstract class Shape
{ 
    public abstract double GetArea();
    public abstract double GetPerimeter();
    
}
class Triangle : Shape
{
    public float Base { get; set; }
    public float Height { get; set; }
    public float Side { get; set; }
    public override double GetArea() => Base * Height / 2;
    public override double GetPerimeter() => Side * 2+ Base;
}

class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetPerimeter() => Radius * 2 * 3.14;
    public override double GetArea() => Radius * Radius * 3.14;
}

class Rectangle : Shape
{
    public float SideA { get; set; } 
    public float SideB { get; set; } 
    public override double GetArea() => SideA * SideB;
    public override double GetPerimeter() => SideA * 2 + SideB * 2;
    
}

class Program
{
    static void Main()
    {
        Shape[] shapes = new Shape[]
        {
            new Circle { Radius = 3 }, 
            new Triangle { Side = 4, Base = 2, Height = 8},
            new Rectangle { SideA = 38, SideB = 20 },
            new Triangle{Side = 5, Base = 5, Height = 8},
            new Rectangle { SideA = 5, SideB = 10 },
            
        };

        double totalPerimeter = 0;
        
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetType().Name}: {shape.GetArea()}, Perimeter {shape.GetPerimeter()}");
            totalPerimeter += shape.GetPerimeter();
        }
        
        Console.WriteLine($"Total Perimeter: {totalPerimeter}");
    }
}

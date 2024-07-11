// Необходимо создать коллекцию Dictionary, в которой будет находиться 10 различных пар объектов.
// Необходимо вывести содержимое коллекции на экран.
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        var fruits = new Dictionary<int, string>()
        {
            { 1, "Apple"},
            { 2, "Apricot"},
            { 3, "Banana"},
            { 4, "Peach"},
            { 5, "Grape"},
            { 6, "Pear"},
            { 7, "Strawberry"},
            { 8, "Kiwi"},
            { 9, "Orange"},
            { 10, "Pineapple"},
        };
        
        foreach(var fruit in fruits)
        {
            Console.WriteLine($"key: {fruit.Key}  value: {fruit.Value}");
        }
    } 
}
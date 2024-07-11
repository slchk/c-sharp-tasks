// Напишите обобщенный класс, который может хранить в массиве объекты любого типа.
// Кроме того, данный класс должен иметь методы для добавления данных в массив, удаления из массива,
// получения элемента из массива по индексу и метод, возвращающий длину массива.
using System;
using System.Collections;
using System.Net.Sockets;
using task_9_1;
class Program
{
    static void Main()
    {
        GenericArray<int> intArray = new GenericArray<int>(4);
        intArray.Add(1);
        intArray.Add(2);
        intArray.Add(3);
        intArray.Remove(1);
        intArray.ArrayIndex(1);
        intArray.ArrayLength();
        
        GenericArray<string> strArray = new GenericArray<string>(4);
        strArray.Add("car");
        strArray.Add("wheel");
        strArray.Remove("wheel");
        strArray.ArrayIndex(1);


    }
}
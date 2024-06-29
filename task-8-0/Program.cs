// 1. У вас есть следующая коллекция: 
// ArrayList list = new ArrayList();  
// И в вашей программе вызвается следующий код: object s = list[18];
// Необходимо перехватить ошибку и вывести на экран с указанием типа этой ошибки. 
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        
        try
        {
            object s = list[18];
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.GetType());
        }
    } 
}
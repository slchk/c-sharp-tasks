using System;
using System.Runtime.InteropServices.JavaScript;
  
class Phone {
    
    private string Number;
    private string Model;
    private int Weight;

    public Phone(string number, string model, int weight) : this(number,  model)
    {
        Weight = weight;
    }
      
    public Phone(string number, string model)
    {
        Number = number;
        Model = model;
    }
    
    public Phone()
    {
        Number = "Unknown";
        Model = "Apple";
        Weight = 2000;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Phone: {this.Number}, Model: {this.Model}, Weight: {this.Weight}");
    }
    
    public void ReceiveCall(string name)
    {
        Console.WriteLine($"Calling: {name}");
    }
    
    public string GetNumber(string number)
    {
        return  this.Number;
    }
    
    public void ReceiveCall(string name, string number)
    {
        Console.WriteLine($"Calling: {name}, Number: {this.Number}");
    }
    
    public void SendMessage(params string[] number)
    {
        foreach (string num in number)
        {
            Console.WriteLine("SendMessage:" + num);
        }
    }
}

class Program
{
    static void Main()
    {
        Phone firstPhone = new Phone("273-90-94", "Samsung", 1200);
        Phone secondPhone = new Phone("378-80-36", "Apple");
        Phone thirdPhone = new Phone();
        

        firstPhone.PrintInfo();
        secondPhone.ReceiveCall("Kate");     
        thirdPhone.GetNumber("378-80-27");
        secondPhone.ReceiveCall("Peter", "378-80-27");
        thirdPhone.SendMessage("234-45-67", "121-87-94");
        secondPhone.SendMessage("555-45-67");
    }
}


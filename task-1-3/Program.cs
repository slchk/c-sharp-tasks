using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a weather-related word in Russian");
            string sign = Console.ReadLine();
            switch (sign) 
            {
                case "тепло":
                    Console.WriteLine("warm");
                    break;
                case "холодно":
                    Console.WriteLine("cold");
                    break;
                case "погода":
                    Console.WriteLine("weather");
                    break;
                case "жарко":
                    Console.WriteLine("hot");
                    break;
                case "дождь":
                    Console.WriteLine("rain");
                    break;
                case "гром":
                    Console.WriteLine("thunder");
                    break;
                case "снег":
                    Console.WriteLine("snow");
                    break;
                case "солнечно":
                    Console.WriteLine("sunny");
                    break;
                case "ветрено":
                    Console.WriteLine("windy");
                    break;
                case "облачно":
                    Console.WriteLine("cloudy");
                    break;
                default:
                    Console.WriteLine("I know only 10 weather-related words. You entered a word I don't know. Please try again.");
                    break;
            }
        }
    }
}
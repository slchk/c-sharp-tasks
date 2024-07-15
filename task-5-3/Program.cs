// ✨3. Автопарк✨
// Создать класс, cо следующими свойствами: сlass Bus: Пункт назначения, Номер, Время отправления, Число мест
// Определить get, set методы для этих свойств.
// Создать класс с main методом, в котором будет объявлен объект класса Bus. Вывести все данные (значения полей) объекта в консоль. 

// Определить иерархию классов в предметной области: Парк общественного траспорта. 
//Определить иерархию различных видов общественного транспорта (например, Trolleybus, Tramcar и т.д. на подобие класса Bus выше.) 

// Определить в суперклассе (например, сlass Transport) метод, возвращающий тип транспорта (Electric, Rail, и т.п.). Переопределить этот метод в классах наследниках.

// В классе с main методом создать массив объектов из различных видов транспорта.

// Провести сортировку транспорта по количеству мест и вывести данные объектов в консоль.
// Запросить у пользователя время отправления и/или пункт назначения. Найти в массиве объект, соответствующий заданным параметрам, и вывести его данные в консоль. 
// Запросить у пользователя время отправления. Вывести в консоль список транспорта, отправляющегося после заданного времени.

//Выбрать метод в супеклассе (e.g. Transport), который нельзя будет переопределить в классах наследниках и запретить это переопределение.

//Создать класс TransportService. Определить внутри класса TransportService метод printTransportType, который будет принимать объект типа Transport как параметр. 
//Внутри метода printTransportType необходимо вызвать другой метод, возвращающий тип транспорта и вывести эту информацию на консоль. 
//В main вызвать метод printTransportType несколько раз, передавая ему как параметр объекты классов наследников (Bus, Trolleybus и т.д.)

abstract class Transport
{
    public string Destination { get; set; }
    public int Number { get; set; }
    public TimeSpan DepartureTime { get; set; }
    public int Seats { get; set; }
    public abstract string GetTransportType();
    
    public void BookTransport()
    {
        Console.WriteLine("Not overridable method");
    }
}

class Bus : Transport 
{
    public override string GetTransportType()
    {
        return "Electric";
    }
}

class Trolleybus : Transport 
{
    public override string GetTransportType()
    {
        return "Mechanic";
    }
}

class Tramcar : Transport 
{
    public override string GetTransportType()
    {
        return "Rail";
    }
}

class TransportService
{
    public void PrintTransportType(Transport transport)
    {
        Console.WriteLine(transport.GetTransportType());
    }
}

class Program
{
    static void Main()
    {
        Transport[] park = new Transport[]
        {
            new Bus { Destination = "Wola", DepartureTime = TimeSpan.Parse("20:00"), Number = 1, Seats = 34 },
            new Tramcar { Destination = "Praga", DepartureTime = TimeSpan.Parse("14:10"), Number = 2, Seats = 22 },
            new Trolleybus { Destination = "Mokotow", DepartureTime = TimeSpan.Parse("10:00"), Number = 3, Seats = 90 },
        };
        
        Array.Sort(park, (x, y) => x.Seats.CompareTo(y.Seats));
        foreach (var transport in park)
        {
            Console.WriteLine($"Transport {transport.GetType().Name}, Seats Available: {transport.Seats}");
        }
        
        Console.WriteLine("Enter destination:");
        string destination = Console.ReadLine();
        
        bool found = false; 
        foreach (var transport in park)
        {
            if (transport.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Transport {transport.GetType().Name}, Destination: {transport.Destination}, Departure time: {transport.DepartureTime}, Seats Available: {transport.Seats}");
                found = true;
            }
        }
        
        if (!found)
        {
            Console.WriteLine("No transport found with the specified destination.");
        }
        
        Array.Sort(park, (x, y) => x.DepartureTime.CompareTo(y.DepartureTime));
        Console.WriteLine("Enter departure time:");
        string input = Console.ReadLine();
        TimeSpan departure;
        if (TimeSpan.TryParse(input, out TimeSpan departureTime))
        {
            bool result = false;
            foreach (var transport in park)
            {
                if (transport.DepartureTime > departureTime)
                {
                    Console.WriteLine($"Transport {transport.GetType().Name}, Destination: {transport.Destination}, Departure time: {transport.DepartureTime}, Seats Available: {transport.Seats}");
                    result = true;
                }
            }
            if (!result)
            {
                Console.WriteLine("\"No transport found with the specified departure time.");
            }
        }
        else
        {
            Console.WriteLine("Sending time error.");
        }
        
        Transport bus = new Bus();
        Transport trolleybus = new Trolleybus();
        Transport tramcar = new Tramcar();
        TransportService transportService = new TransportService();
        
        transportService.PrintTransportType(bus);
        transportService.PrintTransportType(trolleybus);
        transportService.PrintTransportType(tramcar);
    }
}
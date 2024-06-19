// Cоздать класс, в котором будет статический метод.
// Этот метод принимает на вход три параметра:Login,Password,confirmPassword. Все поля имеют тип данных String.
// Длина login должна быть меньше 20 символов и не должен содержать пробелы.
// Если login не соответствует этим требованиям, необходимо выбросить WrongLoginException.
//Длина password должна быть меньше 20 символов, не должен содержать пробелом и должен содержать хотя бы одну цифру.
//Также password и confirmPassword должны быть равны.
// Если password не соответствует этим требованиям, необходимо выбросить WrongPasswordException.
// WrongPasswordException и WrongLoginException - пользовательские классы исключения с двумя конструкторами – один по умолчанию,
// второй принимает сообщение исключения и передает его в конструктоh класса Exception.
//Метод возвращает true, если значения верны или false в другом случае.
using System.Drawing;
using System;
using System.Linq;

public class WrongLoginException : Exception
{
    public WrongLoginException() : base("Login should be less than 20 characters and should not contain space") { }
    public WrongLoginException(string message) : base(message) { }
}

public class WrongPasswordException : Exception
{
    public WrongPasswordException() : base("Password should be less than 20 characters,should contain digits ans should be equal in both fields") { }
    public WrongPasswordException(string message) : base(message) { }
}

public class Auth
{
    public static bool Login(string login, string password, string confirmPassword)
    {
        
        if (login == null || login.Length > 20 || login.Contains(" "))
        {
            throw new WrongLoginException();
        }
        
        if (password == null || password.Length > 20 || !password.Any(char.IsDigit) || password != confirmPassword)
        {
            throw new WrongPasswordException();
        }
        
        return true;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Auth.Login(" ", "qwerty1", "qwerty1");
        }
        catch (WrongLoginException exception)
        {
            Console.WriteLine($"Error: {exception.Message}");
        }
        catch (WrongPasswordException exception)
        {
            Console.WriteLine($"Error: {exception.Message}");
        }
    }
}



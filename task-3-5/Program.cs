
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string documentNumber = "5553-sos-5678-AbC-1a2b";
            
            // - Вывести на экран в одну строку два первых блока по 4 цифры.
            
            string firstBlock = documentNumber.Substring(0, 4);
            string secondBlock = documentNumber.Substring(9, 4);
            Console.WriteLine(firstBlock + secondBlock);
            
            // - Вывести на экран номер документа, но блоки !!из трех букв!! заменить на *** (каждая буква заменятся на *).
            
            string modifiedDocumentNumber = Regex.Replace(documentNumber, @"\b[a-zA-Z]{3}\b", "***");
            Console.WriteLine(modifiedDocumentNumber);  
            
            // - Вывести на экран только одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре.
            
            string firstPart = documentNumber.Substring(5,3);
            Console.WriteLine(firstPart);
            string secondPart = documentNumber.Substring(14,3);
            Console.WriteLine(secondPart);
            string thirdPart = documentNumber.Substring(19,1);
            Console.WriteLine(thirdPart);
            string fourthPart = documentNumber.Substring(21,1);
            Console.WriteLine(fourthPart);

            string onlyLetters = (firstPart + "/" + secondPart + "/" + thirdPart + "/" + fourthPart);
            string lowerCase = onlyLetters.ToLower(); 
            Console.WriteLine(lowerCase);
            
            // - Вывести на экран буквы из номера документа в формате "Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью класса StringBuilder).

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Letters: {onlyLetters}");
            string upperCase = stringBuilder.ToString().ToUpper();
            Console.WriteLine(upperCase);            
            
            // - Проверить содержит ли номер документа последовательность abc и вывети сообщение содержит или нет(причем, abc и ABC считается
            // одинаковой последовательностью).
            
            string pattern = "abc";
            bool isDocumentСontainsAbc = Regex.IsMatch(documentNumber, pattern:@"[a-zA-Z]");
            Console.WriteLine($"Is Document Сontains Abc? {isDocumentСontainsAbc}");
            
            // Проверить начинается ли номер документа с последовательности 555.
            
            bool startsWith = documentNumber.StartsWith("555");
            Console.WriteLine($"Is Document Starts With 555? {startsWith}");
                
            // Проверить заканчивается ли номер документа на последовательность 1a2b.
            
            bool endsWith = documentNumber.EndsWith("1a2b");
            Console.WriteLine($"Is Document Ends With 1a2b? {endsWith}");
        }
    }
}
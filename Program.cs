using System;

namespace MarcinHoffmannLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz tekst");
            string text = Console.ReadLine();
            Console.WriteLine("Wpisz pierwszą liczbę");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Wpisz drugą liczbę");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"\nWpisałeś tekst:  { text }\n\nPierwsza liczba: { number }\nDruga liczba:    { number2 }");
            Console.WriteLine($"\nWynik dodawania liczb:\t\t { number + number2 }");
            Console.WriteLine($"Wynik odejmowania liczb:\t { number - number2 }");
            Console.WriteLine($"Wynik mnożenia liczb:\t\t { number * number2 }");
            Console.WriteLine($"Wynik dzielenia liczb:\t\t { number / number2 }");
            Console.ReadKey();
        }
    }
}

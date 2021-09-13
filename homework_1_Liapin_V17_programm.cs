
// вариант 17
using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Celsius: ");
            string numberText = Console.ReadLine();
            double number = double.Parse(numberText);
            double  result = ((number * 9/5) +32 );
            Console.WriteLine($"Temperature in Fahrenheit = {result}");

            Console.ReadKey(true);
        }
    }
}

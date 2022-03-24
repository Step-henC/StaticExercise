using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter temperature in Fahrenheit to nearest tenths place:");
            double fahrenTemp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The temperature in Celsius is: ");
            Console.WriteLine(TempConverter.FahrenheitToCelsius(fahrenTemp));

            Console.WriteLine("Please enter temperature in Celsius to nearest tenths place: ");
            double celsTemp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The temperature in Fahrenheit is: ");
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(celsTemp));

            Console.ReadLine();




        }
    }
}

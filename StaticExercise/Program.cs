using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"{TempConverter.FahrenheitToCelsius(100)} Celsius");
            Console.WriteLine();
            Console.WriteLine($"{TempConverter.CelsiusToFahrenheit(13)} Fahrenheit");


        }
    }
}

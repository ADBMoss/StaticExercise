using System;
namespace StaticExercise
{
    public static class TempConverter
    {
      


        public static double FahrenheitToCelsius(double value)
        {
            double result = (value - 32) * 5556;
            return result;
            
        }

        public static double CelsiusToFahrenheit(double value)
        {
            double result = (value * 1.8) + 32;
            return result;

        }
    }
}

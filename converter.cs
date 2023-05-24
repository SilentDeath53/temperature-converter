using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");

            Console.Write("Enter the temperature value: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the conversion type (C for Celsius, F for Fahrenheit): ");
            string conversionType = Console.ReadLine();

            double convertedTemperature;
            string convertedUnit;

            if (conversionType.ToUpper() == "C")
            {
                convertedTemperature = FahrenheitToCelsius(temperature);
                convertedUnit = "Celsius";
            }
            else if (conversionType.ToUpper() == "F")
            {
                convertedTemperature = CelsiusToFahrenheit(temperature);
                convertedUnit = "Fahrenheit";
            }
            else
            {
                Console.WriteLine("Invalid conversion type entered. Please try again.");
                return;
            }

            Console.WriteLine("Converted temperature: " + convertedTemperature + " " + convertedUnit);
        }

         static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}

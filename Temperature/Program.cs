using System;

namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Celsius temperature: ");
            string temperatureInput = Console.ReadLine();

            bool isInputNumber = int.TryParse(temperatureInput, out int temperature);
            bool isInputCorrect = temperature >= -273;

            if (!isInputNumber)
            {
                Console.WriteLine("Invalid value, enter number.");
                return;
            }
            if (!isInputCorrect)
            {
                Console.WriteLine("Invalid value, enter correct temperature.");
                return;
            }

            int kelvin = ToKelvin(temperature);
            int fahrenheit = ToFahrenheit(temperature);

            Console.WriteLine($"Celsius: {temperature}");
            Console.WriteLine($"Kelvin: {ToKelvin(kelvin)}");
            Console.WriteLine($"Fahrenheit: {ToFahrenheit(fahrenheit)}");
        }

        static int ToKelvin(int temperature)
        {
            return temperature + 273;
        }

        static int ToFahrenheit(int temperature)
        {
            return temperature + 32;
        }
    }
}

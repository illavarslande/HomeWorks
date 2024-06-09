using System;

namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Celsius temperature: ");
            string temperatureInput = Console.ReadLine();

            bool isInputNumber = int.TryParse(temperatureInput, out int temperature);
            bool isInputCorrect = temperature >= -273;

            if (!isInputNumber)
            {
                Console.WriteLine("Input words, try again");
                return;
            }
            if (!isInputCorrect)
            {
                Console.WriteLine("Input correct temperature.");
                return;
            }

            Console.WriteLine($"Celsius: {temperature}");
            Console.WriteLine($"Kelvin: {ToKelvin(temperature)}");
            Console.WriteLine($"Fahrenheit: {ToFahrenheit(temperature)}");
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

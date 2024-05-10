using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Apartments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество этажей: ");
            int numberOfFloors = int.Parse(Console.ReadLine());

            Console.Write("Введите количество подъездов: ");
            int numberOfEntranses = int.Parse(Console.ReadLine());

            const int numberOfApartmentsPerFloor = 4;

            int numberOfAllApartments = numberOfApartmentsPerFloor * numberOfFloors * numberOfEntranses;

            while (true)
            {
                Console.Clear();
                Console.Write("Введите номер квартиры: ");
                int apartmentNumber = int.Parse(Console.ReadLine());
                if (apartmentNumber <= 0 || apartmentNumber > numberOfAllApartments)
                {
                    Console.Write("Введите корректное значение.");
                    Console.ReadLine();
                }
                else
                {
                    switch (apartmentNumber % numberOfApartmentsPerFloor)
                    {
                        case 1:
                            Console.WriteLine("Квартира находится слева снизу.");
                            break;
                        case 2:
                            Console.WriteLine("Квартира находится слева сверху.");
                            break;
                        case 3:
                            Console.WriteLine("Квартира находится справа сверху.");
                            break;
                        case 0:
                            Console.WriteLine("Квартира находится справа снизу.");
                            break;
                    }

                    double entranseOfApartment = ((apartmentNumber - 1) % (numberOfFloors * numberOfApartmentsPerFloor)) / numberOfApartmentsPerFloor + 1;
                    Console.WriteLine($"Квартира находится в {entranseOfApartment} подъезде.");

                    double floorOfApartment = (apartmentNumber - 1) / (numberOfFloors * numberOfApartmentsPerFloor) + 1;
                    Console.WriteLine($"Квартира находится на {floorOfApartment} этаже.");

                    Console.ReadLine();
                }
            }
        }
    }
}

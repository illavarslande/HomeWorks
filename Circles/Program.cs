﻿using System;

namespace Circles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radiusFirstCircle = 5;
            double areaFirstCircle = Math.PI * Math.Pow(radiusFirstCircle, 2);
            double circumferenceFirstArea = 2 * Math.PI * radiusFirstCircle;
            Console.WriteLine("Радиус первой окружнсти равен " + radiusFirstCircle);
            Console.WriteLine("Её площадь равна " + areaFirstCircle);
            Console.WriteLine("Длина первой окружности равна " + circumferenceFirstArea);

            double areaSecondCircle = 40;
            double angleSectorSecondCircle = 45;
            double radiusSecondArea = Math.Sqrt(areaSecondCircle / Math.PI);
            double areaSectorSecondArea = (Math.PI * Math.Pow(radiusSecondArea, 2)) / 360 * angleSectorSecondCircle;
            Console.WriteLine("Площадь второй окружности равна " + areaSecondCircle);
            Console.WriteLine("Радиус второй окружности равен " + radiusSecondArea);
            Console.WriteLine("Площадь сектора с углом в " + angleSectorSecondCircle + " градусов равна " + areaSectorSecondArea);
        }
    }
}

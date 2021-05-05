﻿using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car bmv = new Car("BMW", "X6", 1993, 5003, -50);
            Car defaultGolf = new Car();
            Console.WriteLine($"Default golf:" + defaultGolf.WhoAmI());
            
            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelConsumption = 200;
            car.FuelQuantity = 200;

            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }
}

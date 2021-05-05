using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class Program
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                //{model} {fuelAmount} {fuelConsumptionFor1km}

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerKilometer = double.Parse(input[2]);

                //opt 1 to initialize object
                Car currCar = new Car(model, fuelAmount,fuelConsumptionPerKilometer);

                //opt 2 inline initialization
                //Car currCar = new Car()
                //{
                //    Model = model,
                //    FuelAmount= fuelAmount,
                //    FuelConsumptionPerKilometer=fuelConsumptionPerKilometer
                //};

                //opt 3
                //currCar.Model = model;
                //currCar.FuelAmount = fuleAmount;
                //currCar.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;

                cars.Add(currCar);
            }

            while (true)
            {
                string inputGo = Console.ReadLine();

                if (inputGo=="End")
                {
                    break;
                }

                string[] action = inputGo.Split();
                //Drive {carModel} {amountOfKm}

                string carModel = action[1];
                double distanceTravelled = double.Parse(action[2]);

                Car car = cars.FirstOrDefault(c => c.Model == carModel);

               bool isValid = car.Drive(distanceTravelled);

                if (isValid)
                {

                }

                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }

        }
    }
}

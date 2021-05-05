using System;
using System.Linq;
using System.Collections.Generic;

namespace RawData
{
    public class Program
    {
        static public void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            //number N - the number of cars you have. 
            int n = int.Parse(Console.ReadLine());

//"{model} {int engineSpeed} {int enginePower} {int cargoWeight} {cargoType} {double tire1Pressure} 
//{double tire1Age}  {double tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string model = input[0];

                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                Engine engine = new Engine(engineSpeed,enginePower);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire[] tires = new Tire[4];

                for (int j = 0; j < 8 ; j+=2)
                {
                    double tirePressure = double.Parse(input[j+5]);
                    int tireAge = int.Parse(input[j+6]);
                    Tire tire = new Tire(tireAge, tirePressure);
                    tires[j / 2] = tire; 
                }


                Car car = new Car(model,engine,cargo,tires);
                cars.Add(car);
            }

            //"fragile" - print all cars whose cargo is "fragile" with a tire, whose pressure is < 1
            //"flamable" - print all of the cars, whose cargo is "flamable" and have engine power > 250
            string command = Console.ReadLine();

            List<Car> filterFragile = new List<Car>();
            List<Car> filterFlamable = new List<Car>();

            if (command== "fragile")
            {
                //filter = (c, command) => c.Cargo.Type == command && c.Tires.Any(t => t.Pressure < 1);
                //List<Car> filterFragile = cars.Where(n => n.Cargo.CargoType ==command).ToList();    
                  //filterFragile = cars.Where(m => m.Tires.Any(t =>t.TirePressure<1)).Where(n => n.Cargo.CargoType == command).ToList();
                filterFragile = cars.Where(n => n.Cargo.CargoType == command && n.Tires.Any(t =>t.TirePressure<1)).ToList();
            }

            else if (command == "flamable")
            {
                filterFlamable = cars.Where(m => m.Engine.EnginePower>250).Where(n => n.Cargo.CargoType == command).ToList();
            }

            foreach (var car in filterFragile)
            {
                Console.WriteLine(car.Model);
            }

            foreach (var car in filterFlamable)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}

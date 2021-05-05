using System;
using System.Linq;
using System.Collections.Generic;

namespace CarSalesman
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            //Engine info 
            HashSet<Engine> engines = new HashSet<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInput = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                //"{model} {power} {displacement} {efficiency}"
                //V8-101     220       50
                //V4-33      140       28              B

                string model = engineInput[0];
                int power = int.Parse(engineInput[1]);

                Engine engine=null;

                if (engineInput.Length == 4)
                {
                    int displacement = int.Parse(engineInput[2]);
                    string efficiency = engineInput[3];

                    engine = new Engine(model, power, displacement, efficiency);
                }

                else if (engineInput.Length == 3)
                {
                    int displacement;

                    bool isDisplacement = int.TryParse(engineInput[2], out displacement);

                    if (isDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, engineInput[2]);
                    }
                }

                else if (engineInput.Length==2)
                {
                    engine = new Engine(model, power);
                }

                if (engine!=null)
                {
                    engines.Add(engine);
                }


                
            }

            //Car info
            int m = int.Parse(Console.ReadLine());
            //Car car = new Car(carInput[0], engines.FirstOrDefault(e => e.Model == carInput[1]));

            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] carInput = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                //"{model} {engine} {weight} {color}" 
                //FordFocus V4-33    1300     Silver

                Car car = null;
                string model = carInput[0];
                //Engine engine = engines.First(e => e.Model == carInput[1]);

                Engine engine = engines.First(e => e.Model == carInput[1]); 
                if (carInput.Length == 4)
                {
                    double weight = double.Parse(carInput[2]);
                    string color = carInput[3];

                    car = new Car(model, engine, weight, color);
                }

                else if (carInput.Length == 3)
                {
                    double weight;

                    bool isWeight = double.TryParse(carInput[2], out weight);

                    if (isWeight)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        car = new Car(model, engine,carInput[2]);
                    }
                }

                else if (carInput.Length == 2)
                {
                    car = new Car(model, engine);
                }

                if (car != null)
                {
                    cars.Add(car);
                }

                
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
            

        }
    }
}

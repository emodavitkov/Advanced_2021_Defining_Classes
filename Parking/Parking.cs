using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }

        public int Count => data.Count;

        public void Add(Car car)
        {
            if (data.Count<Capacity)
            {
                data.Add(car);
            }
            
        }

        public bool Remove(string manifacturer, string model)
        {
            Car car = data.FirstOrDefault(p => p.Manufacturer == manifacturer && p.Model == model);
            
            if (car==null)
            {
                return false;
            }

            data.Remove(car);
            return true;

        }

        public Car GetLatestCar()
        {
            Car car = data.OrderByDescending(m => m.Year).FirstOrDefault();

            //return data.OrderByDescending(m => m.Age).FirstOrDefault();

            if (car ==null)
            {
                Console.WriteLine("null");
            }

            return car;

        }

        public Car GetCar(string manifacturer, string model)
        {
            Car car = data.FirstOrDefault(p => p.Manufacturer == manifacturer && p.Model == model);

            if (car == null)
            {
                Console.WriteLine("null");
            }

            
            return car;

        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {this.Type}:");

            foreach (var car in data)
            {
                sb.AppendLine($"{car}");
            }

            return sb.ToString();
        }

    }
}
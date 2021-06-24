using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;

        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Employee>();
        }

        public string Name { get; set; }
        public  int Capacity { get; set; }

        public int Count => data.Count;

        public void Add(Employee employee)
        {
            if (data.Count<Capacity)
            {
                data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee employee = data.FirstOrDefault(n => n.Name == name);
            if (employee==null)
            {
                return false;
            }

            data.Remove(employee);
            return true;
        }



        public Employee GetOldestEmployee()
        {
            Employee employee = data.OrderByDescending(o => o.Age).FirstOrDefault();

            return employee;
        }

        public Employee GetEmployee(string name)
        {
            Employee employee = data.FirstOrDefault(n => n.Name == name);
            return employee;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name}:");

            foreach (var employee in data)
            {
                sb.AppendLine($"{employee}");
            }

            return sb.ToString();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] dataPerson = Console.ReadLine().Split(" ");

                string name = dataPerson[0];
                int age = int.Parse(dataPerson[1]);

                Person currPerson = new Person(name,age);

                people.Add(currPerson);
                
            }

            List<Person> filteredPeople = people.Where(p => p.Age > 30).OrderBy(n => n.Name).ToList();

            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}

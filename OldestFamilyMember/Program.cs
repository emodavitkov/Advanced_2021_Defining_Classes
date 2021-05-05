using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] personData = Console.ReadLine().Split(" ");

                string name = personData[0];
                int age = int.Parse(personData[1]);

                Person currentPerson = new Person(name, age);

                family.AddMembers(currentPerson);
            }

           
            Person oldestPersonInfamily = family.GetOldestMember();
            Console.WriteLine($"{oldestPersonInfamily.Name} {oldestPersonInfamily.Age}");

            

        }
    }
}

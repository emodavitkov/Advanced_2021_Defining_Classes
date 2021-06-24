using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;

     

        public Clinic(int capacity)
        {
            data = new List<Pet>();
            Capacity = capacity;
        }

        public int Capacity { get; set; }

        public int Count => data.Count;

        public void Add(Pet pet)
        {
            if (data.Count < Capacity)
            {
                data.Add(pet);
            }

        }

        public bool Remove(string name)
        {
            Pet pet = data.FirstOrDefault(p => p.Name == name);

            if (pet==null)
            {
                return false;
            }

            data.Remove(pet);
            return true;

        }

        public Pet GetPet(string name, string owner)
        {
            Pet getOurPet = data.FirstOrDefault(p => p.Name == name&&p.Owner==owner);

            if (getOurPet==null)
            {
                Console.WriteLine("null");
            }
            
            return getOurPet;
            
        }

        public Pet GetOldestPet()
        {
            return data.OrderByDescending(m => m.Age).FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"The clinic has the following patients:");

            foreach (var pet in data)
            {
                result.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return result.ToString();
        }
    }
}
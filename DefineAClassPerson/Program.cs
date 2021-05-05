using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Person personOne = new Person();
            //personOne.Name = "Peter";
            //personOne.Age = 20;

            Person personOne = new Person() 
            { 
                Name = "Peter",
                Age = 20 
            };

            Person personTwo = new Person();
            personTwo.Name = "George";
            personTwo.Age = 18;

            Person personThree = new Person();
            personThree.Name = "Sam";
            personThree.Age = 43;


        }
    }
}

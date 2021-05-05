using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Bear
    {

        //data 

        public string Name { get; set; }

        public int DaySinceEaten { get; set; }

        public int Age { get; set; }

        //behaviour

        public void Eat()
        {
            Console.WriteLine($"The bear {Name} just ate and is happy");
        }
    }
}

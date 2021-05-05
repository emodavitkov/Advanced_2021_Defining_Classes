using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Person
    {

        private string name;
        private int age;

        
        public Person()
        {
            this.name = "no name";
            this.age = 1;
        }

        public Person(int age)
            : this()
        {
            //this.name = "no name";
            this.age = age;
        }

        public Person(string name, int age)
            : this(age)
        {
            this.name = name;
            //this.age = age;

            
        }


        public string Name {
            get
            { 
            return this.name;
            }

            set
            {
                this.name = value;
            }
        
        }
        public int Age { 
            get => this.age; 
            set => this.age = value; 
        }

    }
}

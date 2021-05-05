using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        //below is used only with private fields(поле) когато Creating Constructors, when we need control или валидация 
        //са нужни; otherwise only prop with {get; set}
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

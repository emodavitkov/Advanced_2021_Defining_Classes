using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        //fields

        //ctors

        //methods

        //private methods



        //List<Person> Members = new List<Person>(); OR the ctor + prop below:

        public Family()
        {
            this.Members = new List<Person>();
        }      
        public List<Person> Members { get; set; }
        
        public void AddMembers(Person member)
        {
            this.Members.Add(member);
        }

        public Person GetOldestMember()
        {

            Person person = this.Members.OrderByDescending(m => m.Age).FirstOrDefault();

          
            return person;
        }
    }
}

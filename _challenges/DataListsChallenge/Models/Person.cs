using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataListsChallenge.Models
{
    public class Person
    {
        public Person() { }

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}
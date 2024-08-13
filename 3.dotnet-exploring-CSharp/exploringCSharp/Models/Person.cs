using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploringCSharp.Models
{
    public class Person
    {
        private string _name;
        private int _age;
        public string Name
        {
            get => _name.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                _name = value;
            }
        }
        public string LastName { get; set; }
        public string FullName => $"{Name} {LastName}".ToUpper();
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                _age = value;
            }
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {FullName} and I am {Age} years old.");
        }
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploringCSharp.Models
{
    public class Professor : Person
    {
        public decimal Salary { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FullName} and I am {Age} years old. My salary is {Salary}");
        }
    }
}
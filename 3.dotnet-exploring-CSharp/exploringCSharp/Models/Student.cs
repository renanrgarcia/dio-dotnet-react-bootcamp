using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploringCSharp.Models
{
    public class Student : Person
    {
        public double Grade { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FullName} and I am {Age} years old. I am currently in {Grade} grade");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class_example.Models
{
    public class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }

        public void Power(int a, int b)
        {
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
        }
    }
}
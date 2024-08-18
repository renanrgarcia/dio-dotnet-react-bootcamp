using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP_CSharp.Interfaces;

namespace OOP_CSharp.Models
{
    public class CommonCalculator : ICalculator
    {

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
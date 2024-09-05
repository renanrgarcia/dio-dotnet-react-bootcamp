using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorTDDChallenge
{
    public class Calculator
    {
        private List<string> history;
        public string date;

        public Calculator(string date)
        {
            history = new List<string>();
            this.date = date;
        }

        public int sum(int a, int b)
        {
            int result = a + b;

            history.Insert(0, $"{a} + {b} = {result}");

            return result;
        }

        public int sub(int a, int b)
        {
            int result = a - b;

            history.Insert(0, $"{a} - {b} = {result}");

            return result;
        }

        public int mult(int a, int b)
        {
            int result = a * b;

            history.Insert(0, $"{a} * {b} = {result}");

            return result;
        }

        public int div(int a, int b)
        {
            int result = a / b;

            history.Insert(0, $"{a} / {b} = {result}");

            return result;
        }

        public List<string> getHistory()
        {
            history.RemoveRange(3, history.Count - 3);
            return history;
        }
    }
}
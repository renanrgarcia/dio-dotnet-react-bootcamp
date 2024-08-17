using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models
{
    public abstract class Account
    {
        public Account(int number)
        {
            Number = number;
        }
        protected decimal Balance { get; set; }

        public int Number { get; set; }

        public abstract void Deposit(decimal amount);

        public void GetBalance()
        {
            Console.WriteLine($"Your balance is: {Balance}");
        }
    }
}
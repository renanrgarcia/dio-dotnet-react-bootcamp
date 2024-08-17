using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_CSharp.Models
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(int number) : base(number)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
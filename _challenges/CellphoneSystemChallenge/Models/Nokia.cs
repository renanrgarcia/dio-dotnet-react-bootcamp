using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CellphoneSystemChallenge.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string number, string model, string imei, int memory) : base(number, model, imei, memory)
        {
        }

        public override void Call()
        {
            Console.WriteLine("Calling on Iphone...");
        }

        public override void ReceiveCall()
        {
            Console.WriteLine("Receiving call on Iphone...");
        }

        public override void InstallApp(string app)
        {
            Console.WriteLine($"Installing {app} on Iphone");
        }
    }
}
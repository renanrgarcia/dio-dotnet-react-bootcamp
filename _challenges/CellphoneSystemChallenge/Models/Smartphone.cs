using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CellphoneSystemChallenge.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            IMEI = imei;
            Memory = memory;
        }

        public string Number { get; set; }
        private string Model { get; set; }
        private string IMEI { get; set; }
        private int Memory { get; set; }

        public virtual void Call()
        {
            Console.WriteLine("Calling...");
        }
        public virtual void ReceiveCall()
        {
            Console.WriteLine("Receiving call...");
        }
        public abstract void InstallApp(string app);
    }
}
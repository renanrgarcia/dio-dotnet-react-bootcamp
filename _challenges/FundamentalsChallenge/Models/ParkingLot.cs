using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentalsChallenge.Models
{
    public class ParkingLot
    {
        private decimal initialPrice { get; set; }
        private decimal additionalPrice { get; set; }
        private List<string> vehicles = new List<string>();
        public ParkingLot(decimal initialPrice, decimal additionalPrice)
        {
            this.initialPrice = initialPrice;
            this.additionalPrice = additionalPrice;
        }

        public decimal CalculatePrice(int hours)
        {
            return initialPrice + additionalPrice * hours;
        }

        public void RegisterVehicle()
        {
            Console.WriteLine("Type the license plate to register: ");
            string vehicleToRegister = Console.ReadLine().ToUpper();
            vehicles.Add(vehicleToRegister);
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Type the license plate to remove: ");
            string vehicleToRemove = Console.ReadLine().ToUpper();
            if (vehicles.Any(x => x == vehicleToRemove))
            {
                vehicles.Remove(vehicleToRemove);
                Console.WriteLine("Type the amount of parked hours: ");
                int parkedHours = int.Parse(Console.ReadLine());
                Console.WriteLine($"The vehicle {vehicleToRemove} was removed and you have to pay R$ {initialPrice + additionalPrice * parkedHours}");
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }

        }

        public void ListVehicles()
        {
            Console.WriteLine("Cars parked: ");
            if (vehicles.Count == 0)
            {
                Console.WriteLine("There are no cars parked.");
            }
            else
            {
                foreach (string vehicle in vehicles)
                {
                    Console.WriteLine(vehicle);
                }
            }
        }
    }
}
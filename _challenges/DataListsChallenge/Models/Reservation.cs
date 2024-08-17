using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataListsChallenge.Exceptions;

namespace DataListsChallenge.Models
{
    public class Reservation
    {
        public Reservation() { }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public void RegisterGuests(List<Person> guests, Suite suite)
        {
            if (guests.Count < suite.Capacity)
            {
                Guests = guests;
            }
            else
            {
                throw new Exception($"The number of guests is greater than: {Suite.Capacity}.");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestNumber()
        {
            return Guests.Count;
        }

        public decimal CalculateDailyValue()
        {
            decimal reserveValue = ReservedDays * Suite.DailyRate;
            if (ReservedDays >= 10)
            {
                decimal discount = reserveValue * (10M / 100M);
                reserveValue -= discount;
            }
            return reserveValue;
        }
    }
}
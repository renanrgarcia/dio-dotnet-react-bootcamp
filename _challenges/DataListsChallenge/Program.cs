using DataListsChallenge.Models;
using System;

List<Person> guests = new List<Person>();

Person p1 = new Person(name: "Renan", lastName: "Garcia");
Person p2 = new Person(name: "Thaís", lastName: "Andrade");

guests.Add(p1);
guests.Add(p2);

Suite suite = new Suite(suiteType: "Top Master", capacity: 3, dailyRate: 100.00M);

Reservation reservation = new Reservation(reservedDays: 10);
reservation.RegisterSuite(suite);
reservation.RegisterGuests(guests, suite);

Console.WriteLine($"Guests: {reservation.GetGuestNumber()}");
Console.WriteLine($"Daily value: R$ {reservation.CalculateDailyValue()}");
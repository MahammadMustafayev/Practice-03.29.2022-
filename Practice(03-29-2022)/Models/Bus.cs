using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03_29_2022_.Models
{
    class Bus : Vehicle
    {

       
        public int PassengerCount { get; set; }
        public Bus(int passengercount,DateTime year):base(year)
        {
            this.PassengerCount = passengercount;
        }
        public override string ShowInfo()
        {
           return $"Passenger Count:{PassengerCount} Ili:{Year}";
        }
    }
}

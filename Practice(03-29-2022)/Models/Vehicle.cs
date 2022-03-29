using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03_29_2022_.Models
{
   public abstract class Vehicle
    {
        public  string Color { get; set; }
        public  DateTime Year { get; set; }
        public Vehicle( DateTime year)
        {
            this.Year = year;
        }
        public abstract string ShowInfo();
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03_29_2022_.Models
{
    class Car : Vehicle
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public double MaxSpeed { get; set; }
        
        public Car(string brand,string model,DateTime year):base(year)
        {
            this.Brand = brand;
            this.Model = model;
        }

        public override string ShowInfo()
        {
            return $" Ili:{Year} Brand:{Brand} Modeli:{Model} MaxSpeed:{MaxSpeed}";
        }
    }
}

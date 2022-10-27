using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public double DefaultFuelConsumption { get { return FuelConsumption; } }

        public virtual double FuelConsumption { get { return 1.25; } set { } }

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            Fuel -= kilometers * (DefaultFuelConsumption);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }

        public override double FuelConsumption { get => 8; set => base.FuelConsumption = value; }
    }
}

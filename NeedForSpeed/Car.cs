﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }

        public override double FuelConsumption { get => 3; set => base.FuelConsumption = value; }
    }
}

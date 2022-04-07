﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.DataModels
{
    public class WaterMeter
    {
        public int Id { get; set; }
        public int SerialNumber { get; set; }
        public decimal RatePerLiter { get; set; }
        public MeasuringUnit Unit { get; set; }
        public decimal LitersConsumed { get; set; }
        public decimal ConsumptionCost { get; set; }
        public DateTime BillingStartDate { get; set; }
        public DateTime BillingEndDate { get; set; }
    }

    public enum MeasuringUnit
    {
        CubicMeters,
        Liters,
        CubicFeet,
        Gallons
    }
}

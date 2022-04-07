using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.DataModels
{
    public class ElectricityMeter
    {
        public int Id { get; set; }
        public int SerialNumber { get; set; }
        public string MeasuringUnit { get; set; }
        public decimal WattageRating { get; set; }
        public decimal OperationalHours { get; set; }
        public decimal TotalUnits { get; set; }
        public decimal ElecticityConsumed { get; set; }
        public decimal ElecticityConsumedCost { get; set; }
        public DateTime MeterStartDate { get; set; }
        public DateTime BillingStartDate { get; set; }
        public DateTime BillingEndDate { get; set; }

    }
}

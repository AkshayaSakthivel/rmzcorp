using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.DataModels
{
    public class ElectricityMeter
    {
        public int Id { get; set; }
        public Guid SerialNumber { get; set; }
        public string MeasuringUnit { get; set; }
        public decimal WattageRating { get; set; }
        public decimal OperationalHoursPerDay { get; set; }
        public decimal TotalUnits { get; set; }
        public decimal ElecticityConsumedPerHour { get; set; }
        public decimal DailyElecticityConsumedCost { get; set; }
        public DateTime ReadingDate { get; set; }
        public DateTime MeterStartDate { get; set; }
       
    }
}

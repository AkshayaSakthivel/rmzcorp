using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("ZoneId")]
        public Zone Zone { get; set; }
        public int ZoneId { get; set; }
        public DateTime ReadingDate { get; set; }
        public DateTime MeterStartDate { get; set; }
       
    }
}

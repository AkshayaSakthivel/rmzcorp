using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.DataModels
{
    public class WaterMeter
    {
        public int Id { get; set; }
        public Guid SerialNumber { get; set; }
        public decimal RatePerLiter { get; set; }
        public MeasuringUnit Unit { get; set; }
        public decimal LitersConsumedPerDay { get; set; }
        public decimal DailyConsumptionCost { get; set; }
        public DateTime ReadingDate { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MeasuringUnit
    {
        CubicMeters,
        Liters,
        CubicFeet,
        Gallons
    }
}

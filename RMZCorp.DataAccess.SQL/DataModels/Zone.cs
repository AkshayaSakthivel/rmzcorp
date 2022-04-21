using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.DataModels
{
    public class Zone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ElectricityMeter> ElectricityMeters { get; set; }
        public List<WaterMeter> WaterMeters { get; set; }
        [ForeignKey("FloorId")]
        public Floor Floor { get; set; }
        public int FloorId { get; set; }
    }
}

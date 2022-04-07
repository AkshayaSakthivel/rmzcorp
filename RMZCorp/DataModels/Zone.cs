using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.DataModels
{
    public class Zone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ElectricityMeter ElectricityMeter { get; set; }
        public WaterMeter WaterMeter { get; set; }
    }
}

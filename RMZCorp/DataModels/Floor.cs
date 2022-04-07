using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.DataModels
{
    public class Floor
    {
        public int Id { get; set; }
        public int FloorNumber { get; set; }
        public List<Zone> Zones { get; set; }
    }
}

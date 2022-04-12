using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.DataModels
{
    public class Floor
    {
        public int Id { get; set; }
        public int FloorNumber { get; set; }
        public List<Zone> Zones { get; set; }
    }
}

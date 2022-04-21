using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.DataModels
{
    public class Floor
    {
        public int Id { get; set; }
        public int FloorNumber { get; set; }
        public List<Zone> Zones { get; set; }
        [ForeignKey("BuildingId")]
        public Building Building { get; set; }
        public int BuildingId { get; set; }
    }
}

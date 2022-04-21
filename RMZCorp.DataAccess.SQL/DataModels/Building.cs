using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.DataModels
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Floor> Floors { get; set; }
        [ForeignKey("FacilityId")]
        public Facility Facility { get; set; }
        public int FacilityId { get; set; }
    }
}

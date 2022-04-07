using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.DataModels
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Facility> Facilities { get; set; }
    }
}

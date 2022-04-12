using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.DataModels
{
    public class Facility
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public List<Building> Buildings { get; set; }
    }
}

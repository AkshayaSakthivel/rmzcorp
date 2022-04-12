using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.DataModels
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Floor> Floors { get; set; }
    }
}

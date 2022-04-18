using RMZCorp.DataAccess.SQL.Contracts;
using RMZCorp.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMZCorp.Domain.Entities
{
    public class MeterEntity:IMeterEntity
    {

        private readonly IMeterRepo _meterRepo;
        public MeterEntity(IMeterRepo meterRepo)
        {
            _meterRepo = meterRepo;
        }
    }
}

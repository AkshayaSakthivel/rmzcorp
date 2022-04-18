using RMZCorp.DataAccess.SQL.Contracts;
using RMZCorp.DataAccess.SQL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.Repository
{
    public class WaterMeterRepo : IWaterMeterRepo
    {
        public Task<WaterMeter> Add(WaterMeter waterMeter)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<WaterMeter>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<WaterMeter> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WaterMeter> GetBySerialNumber(Guid serialNumber)
        {
            throw new NotImplementedException();
        }

        public Task<WaterMeter> Update(WaterMeter waterMeter)
        {
            throw new NotImplementedException();
        }
    }
}

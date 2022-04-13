using RMZCorp.DataAccess.SQL.DataModels;
using RMZCorps.Domain.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.Repository
{
    public class ElectricityMeterRepo : IElectricityMeterRepo
    {
        public Task<ElectricityMeter> Add(ElectricityMeter electricityMeter)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ElectricityMeter>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ElectricityMeter> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ElectricityMeter> GetBySerialNumber(Guid serialNumber)
        {
            throw new NotImplementedException();
        }

        public Task<ElectricityMeter> Update(ElectricityMeter electricityMeter)
        {
            throw new NotImplementedException();
        }
    }
}

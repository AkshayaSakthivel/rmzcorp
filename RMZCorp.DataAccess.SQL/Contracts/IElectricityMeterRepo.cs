using RMZCorp.DataAccess.SQL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.Contracts
{
    public interface IElectricityMeterRepo
    {
        Task<List<ElectricityMeter>> GetAll();
        Task<ElectricityMeter> GetById(int id);
        Task<ElectricityMeter> GetBySerialNumber(Guid serialNumber);
        Task<ElectricityMeter> Add(ElectricityMeter electricityMeter);
        Task Delete(int id);
        Task<ElectricityMeter> Update(ElectricityMeter electricityMeter);
    }
}

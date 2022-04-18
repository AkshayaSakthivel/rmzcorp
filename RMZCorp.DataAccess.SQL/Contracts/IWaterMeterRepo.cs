using RMZCorp.DataAccess.SQL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.Contracts
{
    public interface IWaterMeterRepo
    {
        Task<List<WaterMeter>> GetAll();
        Task<WaterMeter> GetById(int id);
        Task<WaterMeter> GetBySerialNumber(Guid serialNumber);
        Task<WaterMeter> Add(WaterMeter waterMeter);
        Task Delete(int id);
        Task<WaterMeter> Update(WaterMeter waterMeter);
    }
}

using RMZCorp.DataAccess.SQL.Contracts;
using RMZCorp.DataAccess.SQL.DataModels;
using RMZCorps.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMZCorp.Domain.Entities
{
    public class WaterMeterEntity : IWaterMeterEntity
    {

        private readonly IWaterMeterRepo _waterMeterRepo;
        public WaterMeterEntity(IWaterMeterRepo waterMeterRepo)
        {
            _waterMeterRepo = waterMeterRepo;
        }
        public async Task<WaterMeter> Add(WaterMeter waterMeter)
        {
            return await _waterMeterRepo.Add(waterMeter);
        }

        public async Task Delete(int id)
        {
            await _waterMeterRepo.Delete(id);
        }

        public async Task<List<WaterMeter>> GetAll()
        {
            return await _waterMeterRepo.GetAll();
        }

        public async Task<WaterMeter> GetById(int id)
        {
            return await _waterMeterRepo.GetById(id);
        }

        public async Task<WaterMeter> GetBySerialNumber(Guid serialNumber)
        {
            return await _waterMeterRepo.GetBySerialNumber(serialNumber);
        }

        public async Task<WaterMeter> Update(WaterMeter waterMeter)
        {
            return await _waterMeterRepo.Update(waterMeter);
        }
    }
}

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
    public class ElectricityMeterEntity : IElectricityMeterEntity
    {

        private readonly IElectricityMeterRepo _electricityMeterRepo;
        public ElectricityMeterEntity(IElectricityMeterRepo electricityMeterRepo)
        {
            _electricityMeterRepo = electricityMeterRepo;
        }
        public async Task<ElectricityMeter> Add(ElectricityMeter electricityMeter)
        {
            electricityMeter.SerialNumber = Guid.NewGuid();
            electricityMeter.DailyElecticityConsumedCost = electricityMeter.OperationalHoursPerDay * electricityMeter.WattageRating * electricityMeter.ElecticityConsumedPerHour;
            electricityMeter.TotalUnits += electricityMeter.OperationalHoursPerDay * electricityMeter.ElecticityConsumedPerHour;
            electricityMeter.MeterStartDate = DateTime.Now;
            return await _electricityMeterRepo.Add(electricityMeter);
        }

        public async Task Delete(int id)
        {
            await _electricityMeterRepo.Delete(id);
        }

        public async Task<List<ElectricityMeter>> GetAll()
        {
            return await _electricityMeterRepo.GetAll();
        }

        public async Task<ElectricityMeter> GetById(int id)
        {
            return await _electricityMeterRepo.GetById(id);
        }

        public async Task<ElectricityMeter> GetBySerialNumber(Guid serialNumber)
        {
            return await _electricityMeterRepo.GetBySerialNumber(serialNumber);
        }

        public async Task<ElectricityMeter> Update(ElectricityMeter electricityMeter)
        {
            return await _electricityMeterRepo.Update(electricityMeter);
        }
    }
}

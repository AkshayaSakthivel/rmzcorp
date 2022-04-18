using RMZCorp.DataAccess.SQL.DataModels;
using RMZCorp.DataAccess.SQL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RMZCorp.DataAccess.SQL.Repository
{
    public class ElectricityMeterRepo : IElectricityMeterRepo
    {
        private readonly Context _sqlContext;
        public ElectricityMeterRepo(Context sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public async Task<ElectricityMeter> Add(ElectricityMeter electricityMeter)
        {
            electricityMeter.SerialNumber = Guid.NewGuid();
            await _sqlContext.ElectricityMeters.AddAsync(electricityMeter);
             await _sqlContext.SaveChangesAsync();
            return electricityMeter;
        }

        public async Task Delete(int id)
        {
            var electMeter = await _sqlContext.ElectricityMeters.FindAsync(id);
            if(electMeter != null)
            {
                _sqlContext.ElectricityMeters.Remove(electMeter);
                await _sqlContext.SaveChangesAsync();
            }
        }

        public async Task<List<ElectricityMeter>> GetAll()
        {
            return await _sqlContext.ElectricityMeters.ToListAsync();
        }

        public async Task<ElectricityMeter> GetById(int id)
        {
            return await _sqlContext.ElectricityMeters.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ElectricityMeter> GetBySerialNumber(Guid serialNumber)
        {
            return await _sqlContext.ElectricityMeters.SingleOrDefaultAsync(x => x.SerialNumber == serialNumber);
        }

        public async Task<ElectricityMeter> Update(ElectricityMeter electricityMeter)
        {
            var electMeter = await _sqlContext.ElectricityMeters.FindAsync(electricityMeter.Id);
            if (electMeter != null)
            {
                electMeter.MeasuringUnit = electricityMeter.MeasuringUnit;
                electMeter.WattageRating = electricityMeter.WattageRating;
                electMeter.OperationalHoursPerDay = electricityMeter.OperationalHoursPerDay;
                electMeter.ElecticityConsumedPerHour = electricityMeter.ElecticityConsumedPerHour;
                electMeter.DailyElecticityConsumedCost = electricityMeter.DailyElecticityConsumedCost;
                electricityMeter.ReadingDate = DateTime.Now;
                _sqlContext.ElectricityMeters.Update(electMeter);
                await _sqlContext.SaveChangesAsync();
            }
            return electricityMeter;
            
        }
    }
}

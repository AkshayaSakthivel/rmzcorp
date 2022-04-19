using RMZCorp.DataAccess.SQL.Contracts;
using RMZCorp.DataAccess.SQL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.Repository
{
    public class MeterRepo:IMeterRepo
    {
        private readonly Context _sqlContext;
        public MeterRepo(Context sqlContext)
        {
            _sqlContext= sqlContext;
        }
        public Task<Tuple<List<ElectricityMeter>,List<WaterMeter>>>GetMeterInfo(DateTime? from, DateTime? to,string facilityCode,InfoType infoType,LevelType levelType,int levelId)
        {
            var electricityMeters = new List<ElectricityMeter>();
            var waterMeters = new List<WaterMeter>();
            return Task.FromResult(new Tuple<List<ElectricityMeter>, List<WaterMeter>>(electricityMeters, waterMeters));
        }
    }
}

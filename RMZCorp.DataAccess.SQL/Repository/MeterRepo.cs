using RMZCorp.DataAccess.SQL.Contracts;
using RMZCorp.DataAccess.SQL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.Repository
{
    public class MeterRepo : IMeterRepo
    {
        private readonly Context _sqlContext;
        public MeterRepo(Context sqlContext)
        {
            _sqlContext = sqlContext;
        }
        public Task<Tuple<List<ElectricityMeter>, List<WaterMeter>>> GetMeterInfo(DateTime? fromDate, DateTime? toDate, string facilityCode, InfoType infoType, LevelType levelType, int levelId)
        {
            var electricityMeters = new List<ElectricityMeter>();
            var waterMeters = new List<WaterMeter>();

            var queryEM = from em in _sqlContext.ElectricityMeters
                          join z in _sqlContext.Zones on em.ZoneId equals z.Id
                          join f in _sqlContext.Floors on z.FloorId equals f.Id
                          join b in _sqlContext.Buildings on f.BuildingId equals b.Id
                          join fc in _sqlContext.Facilities on b.FacilityId equals fc.Id
                          where fc.Code == facilityCode
                          select new { ElectricMeter = em, ZoneId = z.Id, FloorId = f.Id, BuildingId = b.Id };

            var queryWM = from wm in _sqlContext.WaterMeters
                          join z in _sqlContext.Zones on wm.ZoneId equals z.Id
                          join f in _sqlContext.Floors on z.FloorId equals f.Id
                          join b in _sqlContext.Buildings on f.BuildingId equals b.Id
                          join fc in _sqlContext.Facilities on b.FacilityId equals fc.Id
                          where fc.Code == facilityCode
                          select new { WatMeter = wm, ZoneId = z.Id, FloorId = f.Id, BuildingId = b.Id };

            if (fromDate != null && toDate != null)
            {
                queryEM = from em in queryEM
                          where em.ElectricMeter.ReadingDate <= fromDate && em.ElectricMeter.ReadingDate >= toDate
                          select em;
                queryWM = from wm in queryWM
                          where wm.WatMeter.ReadingDate <= fromDate && wm.WatMeter.ReadingDate >= toDate
                          select wm;
            }


            switch (levelType)
            {
                case LevelType.Building:
                    queryEM = from em in queryEM
                              where em.BuildingId == levelId
                              select em;
                    queryWM = from wm in queryWM
                              where wm.BuildingId == levelId
                              select wm;
                    break;
                case LevelType.Floor:
                    queryEM = from em in queryEM
                              where em.FloorId == levelId
                              select em;
                    queryWM = from wm in queryWM
                              where wm.FloorId == levelId
                              select wm;
                    break;
                case LevelType.Zone:
                    queryEM = from em in queryEM
                              where em.ZoneId == levelId
                              select em;
                    queryWM = from wm in queryWM
                              where wm.ZoneId == levelId
                              select wm;
                    break;
            }
            switch (infoType)
            {
                case InfoType.Both:
                    electricityMeters = queryEM.Select(s => new ElectricityMeter()
                    {
                        Id = s.ElectricMeter.Id,
                        SerialNumber = s.ElectricMeter.SerialNumber,
                        MeasuringUnit = s.ElectricMeter.MeasuringUnit,
                        WattageRating = s.ElectricMeter.WattageRating,
                        OperationalHoursPerDay = s.ElectricMeter.OperationalHoursPerDay,
                        TotalUnits = s.ElectricMeter.TotalUnits,
                        ElecticityConsumedPerHour = s.ElectricMeter.ElecticityConsumedPerHour,
                        DailyElecticityConsumedCost = s.ElectricMeter.DailyElecticityConsumedCost,
                        ReadingDate = s.ElectricMeter.ReadingDate,
                        MeterStartDate = s.ElectricMeter.MeterStartDate
                    }).ToList();

                    waterMeters = queryWM.Select(w => new WaterMeter()
                    {

                    }).ToList();
                    break;
                case InfoType.Electricity:
                    electricityMeters = queryEM.Select(s => new ElectricityMeter()
                    {
                        Id = s.ElectricMeter.Id,
                        SerialNumber = s.ElectricMeter.SerialNumber,
                        MeasuringUnit = s.ElectricMeter.MeasuringUnit,
                        WattageRating = s.ElectricMeter.WattageRating,
                        OperationalHoursPerDay = s.ElectricMeter.OperationalHoursPerDay,
                        TotalUnits = s.ElectricMeter.TotalUnits,
                        ElecticityConsumedPerHour = s.ElectricMeter.ElecticityConsumedPerHour,
                        DailyElecticityConsumedCost = s.ElectricMeter.DailyElecticityConsumedCost,
                        ReadingDate = s.ElectricMeter.ReadingDate,
                        MeterStartDate = s.ElectricMeter.MeterStartDate
                    }).ToList();

                    break;
                case InfoType.Water:
                    queryWM.Select(w => new WaterMeter()
                    {

                    }).ToList();
                    break;
            }


            return Task.FromResult(new Tuple<List<ElectricityMeter>, List<WaterMeter>>(electricityMeters, waterMeters));
        }
    }
}
using RMZCorp.DataAccess.SQL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMZCorp.DataAccess.SQL.Contracts
{
    public interface IMeterRepo
    {
        Task<Tuple<List<ElectricityMeter>, List<WaterMeter>>> GetMeterInfo(DateTime? fromDate, DateTime? toDate, string facilityCode, InfoType infoType, LevelType levelType, int levelId);
    }
}

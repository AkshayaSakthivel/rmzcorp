using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMZCorp.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeterController : ControllerBase
    {
        private readonly IMeterEntity _meterEntity;
        public MeterController(IMeterEntity meterEntity)
        {
            _meterEntity = meterEntity;
        }

    }
}

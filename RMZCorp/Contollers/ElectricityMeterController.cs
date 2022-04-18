using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMZCorp.DataAccess.SQL.DataModels;
using RMZCorps.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMZCorp.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricityMeterController : ControllerBase
    {
        private readonly IElectricityMeterEntity _electricityMeterEntity;
        public ElectricityMeterController(IElectricityMeterEntity electricityMeterEntity)
        {
            _electricityMeterEntity = electricityMeterEntity;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _electricityMeterEntity.GetAll());
        }

        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var electMeter = await _electricityMeterEntity.GetById(id);
            if(electMeter != null)
            {
                return Ok(electMeter);
            }
            return NotFound("Electcity Meter details not available.");
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(ElectricityMeter electricityMeter)
        {
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + electricityMeter.Id , await _electricityMeterEntity.Add(electricityMeter));
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var electMeter = await _electricityMeterEntity.GetById(id);
            if(electMeter != null)
            {
                await _electricityMeterEntity.Delete(electMeter.Id);
            }
            return NotFound("Electricity Meter does not exist.");
        }

        [HttpPatch]
        [Route("update")]
        public async Task<IActionResult> Update(ElectricityMeter electricity)
        {
            var electMeter = await _electricityMeterEntity.GetById(electricity.Id);
            if(electricity != null)
            {
                return Ok(await _electricityMeterEntity.Update(electricity));
            }
            return NotFound("Electricity Meter does not exist.");
        }
    }
}

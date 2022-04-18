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
    public class WaterMeterController : ControllerBase
    {
        private readonly IWaterMeterEntity _waterMeterEntity;
        public WaterMeterController(IWaterMeterEntity waterMeterEntity)
        {
            _waterMeterEntity = waterMeterEntity;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _waterMeterEntity.GetAll());
        }

        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var electMeter = await _waterMeterEntity.GetById(id);
            if (electMeter != null)
            {
                return Ok(electMeter);
            }
            return NotFound("Water Meter details not available.");
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(WaterMeter waterMeter)
        {
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + waterMeter.Id, await _waterMeterEntity.Add(waterMeter));
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var waterMeter = await _waterMeterEntity.GetById(id);
            if (waterMeter != null)
            {
                await _waterMeterEntity.Delete(waterMeter.Id);
            }
            return NotFound("Water Meter does not exist.");
        }

        [HttpPatch]
        [Route("update")]
        public async Task<IActionResult> Update(WaterMeter waterMeter)
        {
            var watMeter = await _waterMeterEntity.GetById(waterMeter.Id);
            if (watMeter != null)
            {
                return Ok(await _waterMeterEntity.Update(waterMeter));
            }
            return NotFound("Water Meter does not exist.");
        }
    }
}

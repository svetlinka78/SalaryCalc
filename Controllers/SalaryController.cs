using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetSalaryCalc.Models;

namespace NetSalaryCalc.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly ILogger<SalaryController> _logger;
        private ISalaryCalculation _bl;

        public SalaryController(ILogger<SalaryController> logger, ISalaryCalculation bl)
        {
            _logger = logger;
            _bl = bl;
        }

        [HttpPost]
        public ActionResult Calculate([FromBody] Contract taxPayerContr)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            try
            {

                var taxes = _bl.GetData(new Calculator.ContractContext { GrossIncome = taxPayerContr.GrossIncome,    CharitySpent = taxPayerContr.CharitySpent});
                return Ok(taxes);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }

    }
}

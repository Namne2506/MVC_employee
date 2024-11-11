using AppAPI.Repository.Repos;
using AppData.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class SalaryBonusController : Controller
    {
        
        private readonly SalaryBonusRepos repos;

        public SalaryBonusController(SalaryBonusRepos repos)
        {
            this.repos = repos;
        }
        [HttpPost("CreateSalaryBonus")]
        public async Task<IActionResult> CreateSalaryBonus([FromBody] SalaryBonus salaryBonus)
        {
            try
            {
                var result = repos.CreateAsync(salaryBonus);
                return StatusCode(201, result);

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("ListSalaryBonus")]
        public IActionResult GetAll()
        {
            var orders = repos.GetAll();
            try
            {
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("SalaryBonus")]
        public IActionResult Delete(SalaryBonus salaryBonus)
        {
            try
            {
                var data = repos.Delete(salaryBonus);
                return StatusCode(201, data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("SalaryBonuseUpdate")]
        public IActionResult Put(SalaryBonus salaryBonus)
        {
            try
            {
                var data = repos.Update(salaryBonus);
                return StatusCode(201, data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

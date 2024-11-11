using AppAPI.Repository.Repos;
using AppData.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepos repos;

        public EmployeeController(EmployeeRepos repos)
        {
            this.repos = repos;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var data = repos.GetAll();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            try
            {
                var result = repos.CreateEmployeeAsync(employee);
                return StatusCode(201, result);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(Employee employee)
        {
            try
            {
                var KetQua = repos.Delete(employee);
                return Ok(KetQua);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Put(Employee employee)
        {
            try
            {
                var CapNhat = repos.Update(employee);
                return Ok(CapNhat);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
            
    }
}

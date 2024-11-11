using AppAPI.Repository.Repos;
using AppData.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly DepartmentRepos repos;

        public DepartmentController(DepartmentRepos repos)
        {
            this.repos = repos;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var data = repos.GetAll();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Post(Department department)
        {
            try
            {
                var data = repos.Create(department);
                return StatusCode(201, data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        public IActionResult Delete(Department department)
        {
            try
            {
                var data = repos.Delete(department);
                return StatusCode(201, data);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Put(Department  department)
        {
            try
            {
                var data = repos.Update(department);
                return StatusCode(201, data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

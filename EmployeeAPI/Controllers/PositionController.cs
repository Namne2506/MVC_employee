using AppAPI.Repository.Repos;
using AppData.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private readonly PositionRepos repos;

        public PositionController(PositionRepos repos)
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
        public IActionResult Post(Position position)
        {
            try
            {
                var data = repos.Create(position);
                return StatusCode(201, data);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(Position position)
        {
            try
            {
                var data = repos.Delete(position);
                return Ok(data);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}

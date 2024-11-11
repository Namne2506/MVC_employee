using AppAPI.Repository.Repos;
using AppData.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendaceController : ControllerBase
    {
        private readonly AttendanceRepos repos;

        public AttendaceController(AttendanceRepos repos)
        {
            this.repos = repos;
        }

        
    }
}

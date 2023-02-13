using BackendApi.Context;
using BackendApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : Controller
    {

        // Declaration context class
        private readonly AppDbContext _authContext;
        public JobController(AppDbContext appDbContext)
        {
            _authContext = appDbContext;
        }



        // ----------------------------------- POST JOB -----------------------------------
        [HttpPost("postjob")]
        public async Task<IActionResult> PostJob([FromBody] Job jobObj)
        {
            if (jobObj == null)
                return BadRequest();

            await _authContext.Jobs.AddAsync(jobObj);
            await _authContext.SaveChangesAsync();
            return Ok(new
            {
                Message = "Trabajo Registrado!"
            });

        }


        // ----------------------------------- GET ALL JOBS -----------------------------------
        [Route("GetJobs")]
        [HttpGet]
        public async Task<IEnumerable<Job>> Get()
        {
            return await _authContext.Jobs.ToListAsync();
        }



        // ----------------------------------- GET JOB BY ID -----------------------------------
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var job = await _authContext.Jobs.FindAsync(id);
                if(job == null)
                {
                    return NotFound();
                }
                return Ok(job);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

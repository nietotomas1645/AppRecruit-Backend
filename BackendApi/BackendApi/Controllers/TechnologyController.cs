using BackendApi.Context;
using BackendApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : Controller
    {
        private readonly AppDbContext _authContext;
        public TechnologyController(AppDbContext appDbContext)
        {
            _authContext = appDbContext;
        }

        [Route("GetAllTechnology")]
        [HttpGet]
        public async Task<IEnumerable<Technology>> Get()
        {
            return await _authContext.Technologies.ToListAsync();
        }
    }
}

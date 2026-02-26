using MeraApplication.Data;
using MeraApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MeraApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public CountryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("api/[controller]/create")]
        public ActionResult<Country> Create([FromBody]Country country)
        {
            _dbContext.Countries.Add(country);
            _dbContext.SaveChanges();
            return Ok(); 
        }

    }
}

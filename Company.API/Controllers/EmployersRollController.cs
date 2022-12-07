using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesInstructorsController : ControllerBase
    {
        private readonly IDbService _db;
        public CoursesInstructorsController(IDbService db) => _db = db;

        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployersRollDTO employersRoll) =>
            await _db.HttpAddAsync<EmployersRoll, EmployersRollDTO>(employersRoll);

        [HttpDelete]
        public async Task<IResult> Delete(EmployersRollDTO dto) =>
            await _db.HttpDeleteAsync<EmployersRoll, EmployersRollDTO>(dto);
    }
}


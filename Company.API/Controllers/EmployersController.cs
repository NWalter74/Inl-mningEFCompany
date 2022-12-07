using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployersController : ControllerBase
    {
        private readonly IDbService _db;
        public EmployersController(IDbService db) => _db = db;

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Employer, EmployerDTO>();

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.HttpSingleAsync<Employer, EmployerDTO>(id);

        // POST api/<CompanyController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployerDTO employer) =>
            await _db.HttpPostAsync<Employer, EmployerDTO>(employer);

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] EmployerDTO employer) =>
             await _db.HttpPutAsync<Employer, EmployerDTO>(id, employer);

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<Employer>(id);
    }
}

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IDbService _db;
        public CompanyController(IDbService db) => _db = db;

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IResult> Get() =>
            await _db.HttpGetAsync<MyCompany, CompanyDTO>();

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.HttpSingleAsync<MyCompany, CompanyDTO>(id);

        // POST api/<CompanyController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] CompanyDTO company) =>
            await _db.HttpPostAsync<MyCompany, CompanyDTO>(company);

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] CompanyDTO company) =>
             await _db.HttpPutAsync<MyCompany, CompanyDTO>(id, company);

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<MyCompany>(id);
    }
}

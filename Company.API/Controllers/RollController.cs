using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RollController : ControllerBase
    {
        private readonly IDbService _db;
        public RollController(IDbService db) => _db = db;

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Roll, RollDTO>();

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.HttpSingleAsync<Roll, RollDTO>(id);

        // POST api/<CompanyController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] RollDTO roll) =>
            await _db.HttpPostAsync<Roll, RollDTO>(roll);

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] RollDTO roll) =>
             await _db.HttpPutAsync<Roll, RollDTO>(id, roll);

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<Roll>(id);
    }
}

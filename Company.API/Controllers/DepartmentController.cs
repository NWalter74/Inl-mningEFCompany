using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDbService _db;
        public DepartmentController(IDbService db) => _db = db;

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Department, DepartmentDTO>();

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.HttpSingleAsync<Department, DepartmentDTO>(id);

        // POST api/<CompanyController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] DepartmentDTO company) =>
            await _db.HttpPostAsync<Department, DepartmentDTO>(company);

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] DepartmentDTO company) =>
             await _db.HttpPutAsync<Department, DepartmentDTO>(id, company);

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<Department>(id);
    }
}

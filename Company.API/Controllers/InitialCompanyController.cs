using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InitialCompanyController : ControllerBase
    {
        private readonly IDbService _db;
        public InitialCompanyController(IDbService db) => _db = db;

        // GET: api/<SlaskController>
        [HttpGet]
        public async Task<IResult> Get() =>
            Results.Ok(await _db.GetAsync<MyCompany, CompanyDTO>());

        // GET api/<SlaskController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            var result = await _db.SingleAsync<MyCompany, CompanyDTO>(e => e.Id.Equals(id));
            if (result is null) return Results.NotFound();
            return Results.Ok(result);
        }


        // POST api/<SlaskController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] CompanyDTO dto)
        {
            try
            {
                var entity = await _db.AddAsync<MyCompany, CompanyDTO>(dto);
                if (await _db.SaveChangesAsync())
                {
                    var node = typeof(MyCompany).Name.ToLower();
                    return Results.Created($"/{node}s/{entity.Id}", entity);
                }
            }
            catch (Exception ex)
            {
                return Results.BadRequest($"Couldn't add the {typeof(MyCompany).Name} entity.\n{ex}.");
            }

            return Results.BadRequest($"Couldn't add the {typeof(MyCompany).Name} entity.");
        }

        // PUT api/<SlaskController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] CompanyDTO dto)
        {
            try
            {
                if (!await _db.AnyAsync<MyCompany>(e => e.Id.Equals(id))) return Results.NotFound();

                _db.Update<MyCompany, CompanyDTO>(id, dto);
                if (await _db.SaveChangesAsync()) return Results.NoContent();

            }
            catch (Exception ex)
            {
                return Results.BadRequest($"Couldn't update the {typeof(MyCompany).Name} entity.\n{ex}.");
            }

            return Results.BadRequest($"Couldn't update the {typeof(MyCompany).Name} entity.");
        }

        // DELETE api/<SlaskController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            try
            {
                if (!await _db.DeleteAsync<MyCompany>(id)) return Results.NotFound();

                if (await _db.SaveChangesAsync()) return Results.NoContent();
            }
            catch (Exception ex)
            {
                return Results.BadRequest($"Couldn't delete the {typeof(MyCompany).Name} entity.\n{ex}.");
            }

            return Results.BadRequest($"Couldn't delete the {typeof(MyCompany).Name} entity.");

        }
    }
}

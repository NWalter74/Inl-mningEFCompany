using Microsoft.EntityFrameworkCore.Metadata.Internal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CompanyContext>(
 options =>
 options.UseSqlServer(
 builder.Configuration.GetConnectionString("CompanyConnection")));

ConfigureAutoMapper(builder.Services);
RegisterServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

// Configuration Methods
void ConfigureAutoMapper(IServiceCollection services)
{
    /* a configuration object for AutoMapper, which registers 
    the mappings between entities and DTOs. The CreateMap method adds a mapping 
    from an entity to a DTO, and the ReverseMap method ads a mapping from DTO to 
    Entity.*/
    var config = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<MyCompany, CompanyDTO>().ReverseMap();
        cfg.CreateMap<Department, DepartmentDTO>().ReverseMap();
        cfg.CreateMap<Employer, EmployerDTO>().ReverseMap();
        cfg.CreateMap<EmployersRoll, EmployersRollDTO>().ReverseMap();
        cfg.CreateMap<Roll, RollDTO>().ReverseMap();
    });
    var mapper = config.CreateMapper();
    services.AddSingleton(mapper);
}

void RegisterServices(IServiceCollection services)
{
    /* To register a service with the AddScoped method, so that its instances lives for the entire HTTP 
    request. By registering the service with the interface, it can be injected into a 
    constructor and receive an instance of the DbService class*/
    services.AddScoped<IDbService, DbService>();
}

void AddCors(IServiceCollection services, string corsName)
{
    builder.Services.AddCors(options =>
    {
        options.AddPolicy(name: corsName,
        policy =>
        {
            policy.WithOrigins("http://localhost:5000", "https://localhost:5001")
                  .AllowAnyMethod().AllowAnyHeader();
        });
    });
}
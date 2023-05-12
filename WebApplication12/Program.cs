using Dapper;
using WebApplication12.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IDbService, DbService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
DefaultTypeMap.MatchNamesWithUnderscores = true;

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

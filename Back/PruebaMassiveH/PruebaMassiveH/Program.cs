using Microsoft.EntityFrameworkCore;
using PruebaMassiveH.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "server=localhost;user=root;password=pacheco;database=massive";
var serverVersion = new MySqlServerVersion(new Version(8, 0, 33));
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseMySql(connectionString, serverVersion));

const string policyName = "CorsPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policyName, builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});



var app = builder.Build();
app.UseRouting();
app.UseCors(policyName);
app.UseAuthorization();
app.MapControllers();

app.Run();

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

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*")
                          ;
                      });
});



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();

app.MapControllers();

app.Run();

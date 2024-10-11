using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.Extensions.DependencyInjection;
using SamarahApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Update this line to use Pomelo for MySQL
builder.Services.AddDbContext<SamarahAppContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("SamarahAppContext")
        ?? throw new InvalidOperationException("Connection string 'SamarahAppContext' not found."),
        new MySqlServerVersion(new Version(8, 0, 21)))); // Specify your MySQL version here

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

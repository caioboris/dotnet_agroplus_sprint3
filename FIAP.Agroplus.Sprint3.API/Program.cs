using FIAP.Agroplus.Sprint3.Application.Extensions;
using FIAP.Agroplus.Sprint3.Infrastructure.Context;
using FIAP.Agroplus.Sprint3.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddServices();
builder.Services.AddRepositories();

builder.Services.AddSingleton<ConfigurationManager>();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseOracle(builder.Configuration["ConnectionStrings:Oracle"]);
});

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

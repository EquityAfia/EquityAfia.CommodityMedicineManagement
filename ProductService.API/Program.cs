
using Microsoft.EntityFrameworkCore;
//using ProductService.Application.Services;
using ProductService.Infrastructure;
using ProductService.Infrastructure.Repositories;
using ProductService.Infrastructure.Data;
using ProductService.Domain.Interfaces;
using ProductService.Application.Interfaces.Commands;
using ProductService.Application.Interfaces.Queries;
using YourSolution.Application.Services.Queries;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBCS")));



builder.Services.AddControllers();
builder.Services.AddScoped<IProductCommandService, ProductCommandService>();
builder.Services.AddScoped<IProductQueryService, ProductQueryService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductDbContext>(e =>e.UseSqlServer(builder.Configuration.GetConnectionString("DBCS")));
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

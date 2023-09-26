using Microsoft.EntityFrameworkCore;
using RetailResaleApi.Context;
using RetailResaleApi.Interfaces;
using RetailResaleApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<RetailResaleContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RetailResaleDb")));

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IConditionService, ConditionService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(options => options.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader());
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

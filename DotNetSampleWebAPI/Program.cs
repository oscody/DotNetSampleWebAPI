

using DataAccess;
using DataAccess_Interfaces;
using Microsoft.EntityFrameworkCore;
using Services;
using Services_Interfaces;

var builder = WebApplication.CreateBuilder(args);



var connectionString = builder.Configuration.GetConnectionString("DbConnectionString");

builder.Services.AddDbContext<TestContext>(options =>
{
    options.UseSqlServer(connectionString);

});

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
//builder.Services.AddScoped<IProductsRepository, ProductRepository>();


builder.Services.AddScoped<ITestService, TestService>();


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

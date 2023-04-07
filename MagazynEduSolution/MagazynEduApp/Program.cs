using MagazynEduApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using MediatR;
using System.Reflection;
using MagazynEduApp.ApplicationServices.API.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddDbContext<WarehouseStorageContext>(
    opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("WarehouseDatabaseConnection")));

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
//builder.Services.AddMediatR(typeof(ResponseBase<>)); //<- zamiast linii wy¿ej?

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

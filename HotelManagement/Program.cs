using HotelManagement.Data;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Az adatb�zis kapcsolat regisztr�l�sa
builder.Services.AddDbContext<HotelDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AzureDbConnection")));

// Az API m�k�d�s�hez sz�ks�ges Swagger konfigur�l�sa 
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
app.MapControllers();  // A v�gpontok bejegyz�se

app.Run();

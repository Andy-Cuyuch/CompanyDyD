using BackendCrudMascota.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AplicationDBContext>(options =>
{
    // Lo que estasmo haciendo es aaceder a la conexion 
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionBack"));
});

builder.Services.AddCors(options =>
    options.AddPolicy("AllowWebapp",
        builder => builder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("AllowWebapp");

app.UseHttpsRedirection();

app.UseAuthorization(); 

app.MapControllers();

app.Run();

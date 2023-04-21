using BackEnd_Portafolio.Domain.IRepositories;
using BackEnd_Portafolio.Domain.IServices;
using BackEnd_Portafolio.Persistence.Context;
using BackEnd_Portafolio.Persistence.Repositories;
using BackEnd_Portafolio.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add context
builder.Services.AddDbContext<AplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conexion"));

});

//ADD SERVICE
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ILoginService, LoginService>();


//ADD REPOSITORY
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();

// ADD CORS
//Cors

builder.Services.AddCors(options => options.AddPolicy("AllowWebapp",
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

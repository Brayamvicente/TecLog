using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Security.Cryptography;
using TecLog.Models;
using TecLog.Utils;
using System.Net.WebSockets;
using System.Reflection;
using TecLog.Services.Base;
using TecLog.Models.Base;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using TecLog.Services;

var builder = WebApplication.CreateBuilder(args);

RegistrarServicos(builder.Services);

var connection = builder.Configuration.GetConnectionString(Environment.MachineName);

builder.Services.AddDbContext<TecLogDbContext>(options =>
        options.UseSqlServer(Criptografia.Decrypt(connection)));

var app = builder.Build();


app.MapControllers();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

app.UseStaticFiles();

app.UseDefaultFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


void RegistrarServicos(IServiceCollection services)
{
    services.AddControllers();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();

    services.AddScoped<UsuarioService>();
}




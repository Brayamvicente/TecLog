using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Security.Cryptography;
using TecLog.Models;
using TecLog.Utils;
using System.Net.WebSockets;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("TecLog");

builder.Services.AddDbContext<TecLogDbContext>(options =>
        options.UseSqlServer(Criptografia.Decrypt(connection)));


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    try
    {
        var dbcontext = scope.ServiceProvider.GetRequiredService<TecLogDbContext>();
        dbcontext.Database.OpenConnection();

        dbcontext.Database.CloseConnection();

    }
    catch(Exception e) 
    {
        Console.WriteLine(e);
    }
}

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



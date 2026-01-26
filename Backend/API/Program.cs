using Application;
using Infrastructure;
using MediatR;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
//using System.Reflection.Metadata;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(cfg =>
{
    // Lägg till alla profiler som finns i Application assembly
    cfg.AddMaps(typeof(AssemblyReference).Assembly);
});


builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Application.AssemblyReference).Assembly);
});



// Infrastructure (DbContext, repositories)
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

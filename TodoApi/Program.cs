using Microsoft.OpenApi.Models;
using TodoApi.Api.Controllers;
using TodoApi.Bff.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{

    c.SwaggerDoc("api", new OpenApiInfo
    {
        Title = "Public API",
        Version = "v1",
        Description = "Public API"
    });
    c.SwaggerDoc("bff", new OpenApiInfo
    {
        Title = "BFF API",
        Version = "v1",
        Description = "Backend for Frontend API"
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(c =>
    {
        c.RouteTemplate = "swagger/{documentName}/swagger.json";
    });
    // app.UseSwaggerUI();
     app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/api/swagger.json", "Public API V1");
        c.SwaggerEndpoint("/swagger/bff/swagger.json", "BFF API V1");
        c.RoutePrefix = "swagger";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

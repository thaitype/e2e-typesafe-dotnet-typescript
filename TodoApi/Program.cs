using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
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
        c.SwaggerEndpoint("/swagger/bff/swagger.json", "BFF API V1");
        c.RoutePrefix = "swagger/bff";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

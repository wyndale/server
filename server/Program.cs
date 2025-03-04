using Microsoft.EntityFrameworkCore;
using server.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Define CORS Policy
var corsPolicy = "AllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(corsPolicy, policy =>
    {
        policy.WithOrigins("http://localhost:8383")  // Allow frontend origin
              .AllowAnyMethod()                     // Allow GET, POST, PUT, DELETE
              .AllowAnyHeader();                    // Allow all headers
    });
});

builder.Services.AddDbContext<ClothingStoreDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Two-TierConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.MapControllers();

app.Run();

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DotNet_TodoApp.Data;
using DotNet_TodoApp.Config;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

var sqlConfig = config.GetSection(nameof(SQLConfig)).Get<SQLConfig>();
builder.Services.AddDbContext<DotNet_TodoAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString(sqlConfig.ConnectionString) ?? throw new InvalidOperationException("Connection string 'DotNet_TodoAppContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();

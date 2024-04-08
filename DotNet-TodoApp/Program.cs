using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DotNet_TodoApp.Data;
using DotNet_TodoApp.Config;
using DotNet_TodoApp.Repositories;
using DotNet_TodoApp.Tests;
using DotNet_TodoApp.Services;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

var sqlConfig = config.GetSection(nameof(SQLConfig)).Get<SQLConfig>();
builder.Services.AddDbContext<DotNet_TodoAppContext>(options =>
    options.UseSqlServer(sqlConfig.ConnectionString));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ITodoRepository, TodoRepository>();
builder.Services.AddTransient<ITodoService, TodoService>();
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

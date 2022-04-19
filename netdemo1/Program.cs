using Microsoft.EntityFrameworkCore;
using netdemo1.BLL;
using netdemo1.DAL;
using netdemo1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/// <summary>
/// 第六步：修改Program.cs
/// </summary>
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddControllers();

/// <summary>
/// 第十一步：注册关系
/// </summary>
builder.Services.AddScoped<IOneDAL, OneDAL>();
builder.Services.AddScoped<IOneBLL, OneBLL>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.EntityFrameworkCore;
using netdemo1.BLL;
using netdemo1.DAL;
using netdemo1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/// <summary>
/// ���������޸�Program.cs
/// </summary>
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddControllers();

/// <summary>
/// ��ʮһ����ע���ϵ
/// </summary>
builder.Services.AddScoped<IOneDAL, OneDAL>();
builder.Services.AddScoped<IOneBLL, OneBLL>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

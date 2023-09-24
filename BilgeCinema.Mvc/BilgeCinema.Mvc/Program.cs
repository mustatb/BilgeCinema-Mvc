using BilgeCinema.Mvc.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// appsettings.js kullan�m� i�in : 

var settings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>(); // Json'dan �ekilen verilerle AppSettings tipindeki class dolduruldu.

builder.Services.AddSingleton(settings);

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();

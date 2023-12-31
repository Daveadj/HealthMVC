using HealthMVC.Models;
using HealthMVC.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<HealthDbContext>(
    options =>
    options.UseSqlServer(
            builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.Configure<ConfigModel>(builder.Configuration.GetSection("Parameters"));

builder.Services.AddHttpClient("HealthClient", (httpClient) =>
{
    httpClient.BaseAddress = new Uri("https://healthservice.priaid.ch/");
});

builder.Services.AddScoped<SymtomService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).CreateLogger();

builder.Host.UseSerilog();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
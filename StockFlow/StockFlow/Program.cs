using Microsoft.AspNetCore.Identity;
using StockFlow.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();
/*
using var scope = app.Services.CreateScope();
var servicesdatacontext = scope.ServiceProvider;
try
{
    await SeedData.Seed();
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
*/
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();

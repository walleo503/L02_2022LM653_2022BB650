using Microsoft.EntityFrameworkCore;
using L02_2022LM653_2022BB650.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<dastosDbConext>(opt =>
                   opt.UseSqlServer(builder.Configuration.GetConnectionString("DatosDbConnection"))
);




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Venta}/{action=Index}/{id?}");


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

using CoffeeShopRegistration.Models.Data;//go to this other folder to bring it in 
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);//customization page part; tell .NET to have database on standby

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("LocalDB")));//hacker gets your code they don't know what your string could be, no breadcrumbs
//.NET now knows how to connect to your database; can do all sorts of SQL series


var app = builder.Build();//Code must come before this

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

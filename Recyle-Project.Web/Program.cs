using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Recyle_Project.Web.Models;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddSession();


builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option => {
        option.Cookie.Name = "Recyle-Project.Web.auth";
        option.ExpireTimeSpan = TimeSpan.FromDays(7);
        option.SlidingExpiration = false;
        option.LoginPath = "/Account/Login";
        option.LogoutPath = "/Account/Logout";
        option.AccessDeniedPath = "/Home/AccesDenied";

    });
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IRecyleObjectDal, EfRecyleObjectRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();
//app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

using App.Web.Mvc.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConStr")));

var app = builder.Build();

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

//app.MapControllerRoute(
//    name: "Login",
//    pattern: "Auth/{controller=Auth}/{action=Login}/{id?}");

//app.MapControllerRoute(
//    name: "Register",
//    pattern: "Auth/{controller=Auth}/{action=Register}/{id?}");

//app.MapControllerRoute(
//    name: "Auth",
//    pattern: "Auth/{controller=Auth}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "PageDetail",
    pattern: "PageDetail/{controller=Page}/{action=Detail}/{id?}");

app.MapControllerRoute(
    name: "BlogDetail",
    pattern: "BlogDetail/{controller=Blog}/{action=Detail}/{id?}");



app.Run();

using App.Business;
using App.Business.Services;
using App.Business.Services.Abstract;
using App.Persistence.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConStr")));

builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".Genel.Session";
    options.IdleTimeout = TimeSpan.FromSeconds(120);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;

}
);

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IPageService, PageService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ISettingService, SettingService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddControllersWithViews();

builder.Services.AddHttpContextAccessor();

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

app.UseSession();

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

//app.MapControllerRoute(
//    name: "admin",
//    pattern: "admin/{controller=Home}/{action=Index}/{id?}",
//    defaults: new { area = "Admin" }
//);

app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


app.Run();
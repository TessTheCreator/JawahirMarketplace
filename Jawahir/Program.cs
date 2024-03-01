using Jawahir.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Jawahir.Models.User;
using Jawahir.Models.ProductModel;
using Jawahir.Models.MarketModel;
using Microsoft.AspNetCore.Builder;
using System.Diagnostics;
using Jawahir.Models.CategoryModel;
using Training_Project.Models.SeedData;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("JawahirConn") ?? throw new InvalidOperationException("Connection string 'JawahirDbContextConnection' not found.");

// Add services to the container.
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IMarketRepository, MarketRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();



builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<JawahirDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration["ConnectionStrings:JawahirConn"]);
});



builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
	.AddEntityFrameworkStores<JawahirDbContext>().AddDefaultTokenProviders().AddDefaultUI();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseAuthentication();
app.MapRazorPages();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


DbInitializer.Seed(app);
app.Run();

using Microsoft.EntityFrameworkCore;
using Pustok.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDBC>(options =>
           options.UseSqlServer("server=DESKTOP-HD09TL8;database=PustokWA;Trusted_connection=true;Integrated security=true;encrypt=false")
       );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

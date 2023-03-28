using Etel.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOutputCaching();
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IEtelRepository, EtelRepository>();

builder.Services.AddDbContext<EtelDbContext>(options =>
{
    options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EtelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseOutputCaching();
app.UseRouting();
app.MapControllers();
app.MapControllerRoute(name: "default", pattern: "{controller=Etel}/{action=Index}/{id?}");

app.UseAuthorization();

app.MapRazorPages();

app.Run();

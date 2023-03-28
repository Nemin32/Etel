var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.MapControllers();
app.MapControllerRoute(name: "default", pattern: "{controller=Etel}/{action=Index}/{id?}");

app.UseAuthorization();

app.MapRazorPages();

app.Run();

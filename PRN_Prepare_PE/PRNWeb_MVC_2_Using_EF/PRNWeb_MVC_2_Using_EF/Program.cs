using Library.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<MyDBContext>();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=List}/{id?}");

app.Run();
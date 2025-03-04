using EmployeeCRUDAppWithDB.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder. Services. AddScoped<IEmployeeService, EmployeeDatabaseService>();
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Employee}/{action=DisplayAll}/{id?}");

app.Run();

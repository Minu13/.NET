
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<LoginFormWithValidation.Data.AuthorizationService>();
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(
     name: "default",
     pattern: "{controller=Authentication}/{action=Login}/{id?}"
    );

app.Run();

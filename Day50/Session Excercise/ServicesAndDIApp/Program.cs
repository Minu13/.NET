using ServicesAndDIApp.Middilewares;
using ServicesAndDIApp.Services;
using ServicesAndDIApp.Middilewares;
using ServicesAndDIApp.Services;

var builder = WebApplication.CreateBuilder(args);

//DI container
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IRRdEmailService, TwilioEmailService>();


var app = builder.Build();//abover build register sevices


app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();//above run register middleware


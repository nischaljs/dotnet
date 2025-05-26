var builder = WebApplication.CreateBuilder(args);
//for every view we need the controller after this, the controller will respond
builder.Services.AddControllersWithViews();

var app = builder.Build();
// this is used to serve the static things inside the wwwroot folder similar to public in js 
app.UseStaticFiles();
//this means the controllers folder is in the root place in the same heirarchy
app.MapDefaultControllerRoute();


app.Run();

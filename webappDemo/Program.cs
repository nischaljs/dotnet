// Create a new web application builder to set up the app
var builder = WebApplication.CreateBuilder(args);

// Add support for controllers and views to enable MVC functionality
builder.Services.AddControllersWithViews();

// Build the application using the configured services
var app = builder.Build();

// Enable serving of static files (like CSS, JS, images) from the wwwroot folder
app.UseStaticFiles();

// Set up default routing convention for controllers:
// This maps routes like /Home/Index to Controllers/HomeController.cs
app.MapDefaultControllerRoute();

// Start the application and begin listening for HTTP requests
app.Run();

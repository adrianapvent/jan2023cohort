var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();  // Adding the ability to use Controller files to restrict personalize views
var app = builder.Build();

app.UseStaticFiles(); // enabling the user of css/js/imgs
app.UseRouting(); // enables us to have more than one route / page / view
app.UseAuthorization(); // used with db for auth / login

// is for error templates
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");  // This helps set up the pattern for our routes and tells the program to look for the routes in the controller files

// app.MapGet("/", () => "Hello World! What a wonderful day today is!  Just testing the watch run");

app.Run();

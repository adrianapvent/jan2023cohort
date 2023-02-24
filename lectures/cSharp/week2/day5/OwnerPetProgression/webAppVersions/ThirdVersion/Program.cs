var builder = WebApplication.CreateBuilder(args);
// Add our service
builder.Services.AddControllersWithViews();
var app = builder.Build();


// Our builder code
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
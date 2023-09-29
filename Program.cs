var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();

var app = builder.Build();

app.UseStaticFiles();

//app.UseRouting();

app.MapDefaultControllerRoute();

//app.MapRazorPages();

app.Run();
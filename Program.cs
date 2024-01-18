using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Options;
using satellites.Data;
using satellites.Data.Interfaces;
using satellites.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContent>(options => options.UseSqlServer(connection));



builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IAllSatellites, SatellitesRepository>();
builder.Services.AddScoped<IPlanets, PlanetsRepository>();
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    AppDbContent content = scope.ServiceProvider.GetRequiredService<AppDbContent>();
    DBObjects.inital(content);
}



app.UseStaticFiles(); 
app.UseMvcWithDefaultRoute();
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.Run();

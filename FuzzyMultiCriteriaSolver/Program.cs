using FuzzyMultiCriteriaSolver.Managers;
using FuzzyMultiCriteriaSolver.Util;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

var connectionString = "server=127.0.0.1;user=root;password=root;database=FuzzyMultiCriteriaSolver";
builder.Services.AddDbContext<CriteriaSolverContext>(options =>
{
	options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IObjectivesStorageManager, ObjectiveStorageManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

app.UseStaticFiles();
app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
	c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});


app.MapControllerRoute(
	name: "default",
	pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();

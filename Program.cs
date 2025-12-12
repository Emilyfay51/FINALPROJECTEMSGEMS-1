using Microsoft.EntityFrameworkCore;
using  FinalProjectEmsGems_1.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSession();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ProductConnection")));

var app = builder.Build();

// Seed Data
using (var scope = app.Services.CreateScope())
{
        SeedData.Initialize(scope.ServiceProvider);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseSession();

app.UseRouting();

app.UseAuthorization();


// Seed the database

app.MapStaticAssets();
app.MapRazorPages()
    .WithStaticAssets();

app.Run();

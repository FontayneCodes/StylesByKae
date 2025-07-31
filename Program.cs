using Microsoft.EntityFrameworkCore;
using DemoHairSite.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts(); // Use HSTS in non-dev environments
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // ✅ This serves CSS, JS, images, etc.

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

using Microsoft.EntityFrameworkCore;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("MyPortfolioDB");
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(connectionString));

var app=builder.Build();
app.UseStaticFiles();   
app.UseHttpsRedirection();
app.UseRouting();
app.MapControllerRoute(
    name: "default",    
    pattern:  "{controller=Home}/{action=Index}/{Id?}"
    );



app.Run();

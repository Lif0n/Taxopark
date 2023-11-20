using Microsoft.EntityFrameworkCore;

using Taxopark;

var builder = WebApplication.CreateBuilder(args);

//        private readonly string _connectionString = "Data Source=192.168.227.12; initial Catalog=TaxoparkBesSen;" +
//"User ID=user04;Password=04;TrustServerCertificate=True";
string _connectionString = "Data Source=DESKTOP-29PRVP2; initial Catalog=Taxopark; " +
    "Integrated Security=True;TrustServerCertificate=True";

// Add services to the container.
//builder.Services.AddDbContext<MainContext>(options => options.UseSqlServer(_connectionString));
builder.Services.AddDbContext<MainContext>();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Orders}/{action=Index}/{id?}");
app.Run();

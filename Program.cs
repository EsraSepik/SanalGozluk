using Microsoft.AspNetCore.StaticFiles; // 3D dosyalar için gerekli
using Microsoft.EntityFrameworkCore;    // Veritabanı için gerekli
using SanalGozluk.Data;                 // Veritabanı context'i için gerekli

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// --- 1. VERİTABANI BAĞLANTISI ---
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=gozluk.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// --- 2. 3D MODEL (.glb) DOSYA İZNİ ---
var provider = new FileExtensionContentTypeProvider();
provider.Mappings[".glb"] = "model/gltf-binary";
provider.Mappings[".gltf"] = "model/gltf+json";

app.UseStaticFiles(new StaticFileOptions
{
    ContentTypeProvider = provider
});
// --------------------------------------

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
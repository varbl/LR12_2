using LR12_2.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Додайте службу для підключення до бази даних
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("YourConnectionStringHere"));


builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Company}/{action=Index}/{id?}");

// Додайте середовище, у якому контекст бази даних буде доступний
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<AppDbContext>();
        // Тут ви можете додати логіку для ініціалізації бази даних, якщо потрібно
    }
    catch (Exception ex)
    {
        // Обробка помилок при створенні контексту бази даних
    }
}

app.Run();
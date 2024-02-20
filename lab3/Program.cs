using lab3.Interfaces;
using lab3.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ICalculatorService, CalculatorService>();
builder.Services.AddTransient<IDayStateService, DayStateService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(async context =>
{
    var timeService = app.Services.GetService<IDayStateService>();
    await context.Response.WriteAsync($"It's {timeService?.GetDayState()} now");
});
app.Run();

using RockPaperScissors_SimpleV.CurbServices;
using RockPaperScissors_SimpleV.Services;
using Shared.ExceptionHandling;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IGameResults, GameResults>();
builder.Services.AddScoped<IGameChoice, GameChoice>();
builder.Configuration.AddJsonFile("appsettings.json");


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseGlobalExceptionMiddleware();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

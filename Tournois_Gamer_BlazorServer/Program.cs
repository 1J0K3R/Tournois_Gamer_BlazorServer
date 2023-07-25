using MudBlazor.Services;
using Tournois_Gamer_BlazorServer.Data;
using Tournois_Gamer_BlazorServer.Data.Evenement.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<EventServices>();

builder.Services.AddDbContext<DataBaseContext>();

// Add MudBlazor Services.
builder.Services.AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

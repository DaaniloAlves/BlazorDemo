using BlazorDemo.Client.Pages;
using BlazorDemo.Components;
using BlazorDemo.Context;
using BlazorDemo.Repositorios;
using BlazorDemo.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddDbContext<BancoContext>(o => o.UseSqlite(builder.Configuration.GetConnectionString("Sqlite")));
builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDbContext<ClienteContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("ClienteDatabase")));
builder.Services.AddScoped<IClienteRepository, ClienteRepositorio>();
builder.Services.AddScoped(o => new HttpClient
{
    BaseAddress = new Uri(builder.Configuration.GetSection("BaseAdress").Value!)
});

var app = builder.Build();

CreateDatabase(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorDemo.Client._Imports).Assembly);

app.Run();

static void CreateDatabase(WebApplication app)
{
    var serviceScope = app.Services.CreateScope();
    var dataContext = serviceScope.ServiceProvider.GetService<BancoContext>();
    dataContext?.Database.EnsureCreated();
}
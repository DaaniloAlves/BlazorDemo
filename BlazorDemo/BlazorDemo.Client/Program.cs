using BlazorDemo.Client.Services;
using BlazorDemo.Shared.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<IClienteRepositorio, ClienteService>();

await builder.Build().RunAsync();

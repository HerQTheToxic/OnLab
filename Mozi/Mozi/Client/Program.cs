global using Mozi.Client.Services.FilmService;
global using Mozi.Client.Services.TeremService;
global using Mozi.Client.Services.SzekService;
global using Mozi.Client.Services.SzineszService;
global using Mozi.Shared;
global using Syncfusion.Blazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Mozi.Client;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTkzNTg3QDMxMzkyZTM0MmUzMERFNEkrdWRvNTl3UDE5ZEJzVzVTa3AyWlRrdlk2TXN0clhkNnlKUjlJNDQ9");
//kéne license
builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IFilmService, FilmService>();
builder.Services.AddScoped<ITeremService, TeremService>();
builder.Services.AddScoped<ISzekService, SzekService>();
builder.Services.AddScoped<ISzineszService, SzineszService>();
await builder.Build().RunAsync();

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NewBlazorApp;
using ProjectPackage;
using Blazored.LocalStorage; // Add this for local storage support

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add services here
builder.Services.AddScoped<FireStoreManager>();
builder.Services.AddBlazoredLocalStorage(); // Register Blazored.LocalStorage service
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

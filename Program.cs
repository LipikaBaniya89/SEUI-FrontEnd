using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DisasterReliefFrontEnd;
using System.Net.Http;

using DisasterReliefFrontEnd.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register HttpClient for dependency injection
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

// Register your own services
builder.Services.AddScoped<DisasterService>();
builder.Services.AddScoped<AuthService>();

await builder.Build().RunAsync();

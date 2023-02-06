using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//builder.Services.Scan(scan => scan
//    .FromAssemblyOf<IItemClient>()
//    .AddClasses()
//    .AsImplementedInterfaces()
//    .WithScopedLifetime());

builder.Services.AddMudServices();

await builder.Build().RunAsync();

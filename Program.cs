using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using KantoCart.Web;
using KantoCart.Web.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register KantoCart Mock Services
builder.Services.AddScoped<IProductService, MockProductService>();
builder.Services.AddScoped<IDealService, MockDealService>();
builder.Services.AddScoped<CartStateService>();

await builder.Build().RunAsync();
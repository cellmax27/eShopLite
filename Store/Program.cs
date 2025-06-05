using Store.Components;
using Store.Services;


var builder = WebApplication.CreateBuilder(args);

// TODO : other endpoints and servies
var productEndpoint = builder.Configuration["ProductEndpoint"]
                      ?? throw new InvalidOperationException("ProductEndpoint is not set");

builder.Services.AddSingleton<ProductService>();
builder.Services.AddHttpClient<ProductService>(c => c.BaseAddress = new Uri(productEndpoint));









// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();



app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

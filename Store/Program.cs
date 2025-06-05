using Store.Components;
using Store.Services;


var builder = WebApplication.CreateBuilder(args);


var productEndpoint = builder.Configuration["ProductEndpoint"]
                      ?? throw new InvalidOperationException("ProductEndpoint is not set");

builder.Services.AddSingleton<ProductService>();
builder.Services.AddHttpClient<ProductService>(c => c.BaseAddress = new Uri(productEndpoint));




// TODO : other endpoints and servies

var userEndpoint = builder.Configuration["UserEndpoint"]
                      ?? throw new InvalidOperationException("UserEndpoint is not set");

builder.Services.AddSingleton<UserService>();
builder.Services.AddHttpClient<UserService>(c => c.BaseAddress = new Uri(userEndpoint));




var commandeEndpoint = builder.Configuration["CommandeEndpoint"]
                      ?? throw new InvalidOperationException("CommandeEndpoint is not set");

builder.Services.AddSingleton<CommandeService>();
builder.Services.AddHttpClient<CommandeService>(c => c.BaseAddress = new Uri(commandeEndpoint));

///




// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();



app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

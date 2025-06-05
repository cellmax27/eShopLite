using System;
using Store.Components;
using Store.Services;


var builder = WebApplication.CreateBuilder(args);


var productEndpoint = builder.Configuration["ProductEndpoint"]
                      ?? throw new InvalidOperationException("ProductEndpoint is not set");

builder.Services.AddSingleton<ProductService>();
builder.Services.AddHttpClient<ProductService>(c => c.BaseAddress = new Uri(productEndpoint));




// TODO : other endpoints and servies


var authEndpoint = builder.Configuration["AuthEndpoint"]
                      ?? throw new InvalidOperationException("AuthEndpoint is not set");

var userEndpoint = builder.Configuration["UserEndpoint"]
                      ?? throw new InvalidOperationException("UserEndpoint is not set");

builder.Services.AddSingleton<UserService>();
builder.Services.AddHttpClient<UserService>(c => c.BaseAddress = new Uri(userEndpoint));




var commandeEndpoint = builder.Configuration["CommandeEndpoint"]
                      ?? throw new InvalidOperationException("CommandeEndpoint is not set");

builder.Services.AddSingleton<CommandeService>();
builder.Services.AddHttpClient<CommandeService>(c => c.BaseAddress = new Uri(commandeEndpoint));




builder.Services.AddAuthentication();



// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();


/////
///

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//////



app.UseStaticFiles();
// this wires up the antiforgery middleware
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();



app.Run();

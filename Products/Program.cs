using Microsoft.EntityFrameworkCore;
using Products.Data;
using Products.Endpoints;

using Users.Data;
using Users.Endpoints;

using Commandes.Data;
using Commandes.Endpoints;

var builder = WebApplication.CreateBuilder(args);


var productsContext = builder.Configuration.GetConnectionString("ProductsContext") ??
                      throw new InvalidOperationException("Connection string 'ProductsContext' not found.");

builder.Services.AddDbContext<ProductDataContext>(options => options.UseSqlite(productsContext));



// TODO other Contexts  
var usersContext = builder.Configuration.GetConnectionString("UsersContext") ??
                      throw new InvalidOperationException("Connection string 'UsersContext' not found.");
builder.Services.AddDbContext<UserDataContext>(options => options.UseSqlite(usersContext));

var commandesContext = builder.Configuration.GetConnectionString("CommandesContext") ??
                      throw new InvalidOperationException("Connection string 'CommandesContext' not found.");
builder.Services.AddDbContext<CommandeDataContext>(options => options.UseSqlite(commandesContext));
///

///

var apiBaseUrl = builder.Configuration["ApiBaseUrl"] ??
                 throw new InvalidOperationException("Configuration value 'ApiBaseUrl' not found.");
builder.Services.AddHttpClient("ApiClient", client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});


// Add services to the container.  
var app = builder.Build();

// Configure the HTTP request pipeline.  
app.MapProductEndpoints();

app.UseStaticFiles();

// Explicitly specify the namespace to resolve ambiguity  
//app.CreateDbIfNotExists();
Products.Data.Extensions.CreateDbIfNotExists(app);
Users.Data.Extensions.CreateDbIfNotExists(app);
Commandes.Data.Extensions.CreateDbIfNotExists(app);

app.Run();

using DataEntities;
using Microsoft.EntityFrameworkCore;
using Commandes.Data;

namespace Auth.Endpoints;

public static class AuthEndpoints
{
    public static void MapCommandeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/auth/login");

        /*group.MapGet("/", async (CommandeDataContext db) => await db.Commande.ToListAsync())
            .WithName("Authenticate")
            .Produces<List<Commande>>(StatusCodes.Status200OK);*/

       /* group.MapGet("/{id}", async (int id, CommandeDataContext db) => await db.Commande.AsNoTracking()
                    .FirstOrDefaultAsync(model => model.Id == id)
                is { } model
                ? Results.Ok(model)
                : Results.NotFound())
            .WithName("GetCommandeById")
            .Produces<Commande>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);*/


      /*  group.MapPost("/", async (Commande commande, CommandeDataContext db) =>
            {
                db.Commande.Add(commande);
                await db.SaveChangesAsync();
                return Results.Created($"/api/Commande/{commande.Id}", commande);
            })
            .WithName("CreateCommande")
            .Produces<Commande>(StatusCodes.Status201Created);*/

    }
}

using DataEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Products.Data;

namespace Products.Endpoints;

[ApiController]
public static class CommandeEndpoints
{
    public static void MapCommandeEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Commande");

        group.MapGet("/", async (CommandeDataContext db) => await db.Commande.ToListAsync())
            .WithName("GetAllCommandes")
            .Produces<List<Commande>>(StatusCodes.Status200OK);

        group.MapGet("/{id}", async (int id, CommandeDataContext db) => await db.Commande.AsNoTracking()
                    .FirstOrDefaultAsync(model => model.Id == id)
                is { } model
                ? Results.Ok(model)
                : Results.NotFound())
            .WithName("GetCommandeById")
            .Produces<Commande>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

        group.MapPut("/{id}", async (int id, Commande commande, CommandeDataContext db) =>
            {
                var affected = await db.Commande
                    .Where(model => model.Id == id)
                    .ExecuteUpdateAsync(setters => setters
                        .SetProperty(m => m.Id, commande.Id)
                        .SetProperty(m => m.Name, commande.Name)
                        .SetProperty(m => m.Instock, commande.Instock)
                        .SetProperty(m => m.CreatedAt, commande.CreatedAt)
                        .SetProperty(m => m.Product, commande.Product)
                        .SetProperty(m => m.Quantite, commande.Quantite)
                        .SetProperty(m => m.Prix, commande.Prix)
                    );

                return affected is 1 ? Results.Ok() : Results.NotFound();
            })
            .WithName("UpdateCommande")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status204NoContent);

        group.MapPost("/", async (Commande commande, CommandeDataContext db) =>
            {
                db.Commande.Add(commande);
                await db.SaveChangesAsync();
                return Results.Created($"/api/Commande/{commande.Id}", commande);
            })
            .WithName("CreateCommande")
            .Produces<Commande>(StatusCodes.Status201Created);

        group.MapDelete("/{id}", async (int id, CommandeDataContext db) =>
            {
                var affected = await db.Commande
                    .Where(model => model.Id == id)
                    .ExecuteDeleteAsync();

                return affected is 1 ? Results.Ok() : Results.NotFound();
            })
            .WithName("DeleteCommande")
            .Produces<Commande>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);
    }
}

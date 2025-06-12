using DataEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EshopController.Data;

namespace EshopController.Endpoints;

[ApiController]

public static class AuthEndpoints
{
    public static void MapAuthEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/auth/login");

        group.MapGet("/", async (UserDataContext db) => await db.User.ToListAsync())
            .WithName("Authenticate")
            .Produces<List<User>>(StatusCodes.Status200OK);
        
        group.MapGet("/{id}", async (int id, UserDataContext db) => await db.User.AsNoTracking()
                    .FirstOrDefaultAsync(model => model.Id == id)
                is { } model
                ? Results.Ok(model)
                : Results.NotFound())
            .WithName("AuthenticateUserById")
            .Produces<User>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

        /*
        group.MapPost("/", async (User user, UserDataContext db) =>
            {
                db.User.Add(user);
                await db.SaveChangesAsync();
                return Results.Created($"/api/User/{user.Id}", user);
            })
            .WithName("CreateUser")
            .Produces<User>(StatusCodes.Status201Created);
        */
    }
}

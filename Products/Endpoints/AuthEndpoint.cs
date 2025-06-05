using DataEntities;
using Microsoft.EntityFrameworkCore;
using Users.Data;

namespace Auth.Endpoints;

public static class AuthEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder routes)
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
            .WithName("GetUserById")
            .Produces<User>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);


     /*   group.MapPost("/", async (User user, UserDataContext db) =>
            {
                db.User.Add(user);
                await db.SaveChangesAsync();
                return Results.Created($"/api/User/{user.Id}", user);
            })
            .WithName("CreateUser")
            .Produces<User>(StatusCodes.Status201Created);*/

    }
}

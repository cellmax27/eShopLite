using DataEntities;
using Microsoft.EntityFrameworkCore;
using Users.Data;

namespace Users.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/User");

        group.MapGet("/", async (UserDataContext db) => await db.User.ToListAsync())
            .WithName("GetAllUsers")
            .Produces<List<User>>(StatusCodes.Status200OK);

        group.MapGet("/{id}", async (int id, UserDataContext db) => await db.User.AsNoTracking()
                    .FirstOrDefaultAsync(model => model.Id == id)
                is { } model
                ? Results.Ok(model)
                : Results.NotFound())
            .WithName("GetUserById")
            .Produces<User>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

        group.MapPut("/{id}", async (int id, User user, UserDataContext db) =>
            {
                var affected = await db.User
                    .Where(model => model.Id == id)
                    .ExecuteUpdateAsync(setters => setters
                        .SetProperty(m => m.Id, user.Id)
                        .SetProperty(m => m.Name, user.Name)
                        .SetProperty(m => m.Description, user.Description)
                        .SetProperty(m => m.Price, user.Price)
                        .SetProperty(m => m.ImageUrl, user.ImageUrl)
                    );

                return affected is 1 ? Results.Ok() : Results.NotFound();
            })
            .WithName("UpdateUser")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status204NoContent);

        group.MapPost("/", async (User user, UserDataContext db) =>
            {
                db.User.Add(user);
                await db.SaveChangesAsync();
                return Results.Created($"/api/User/{user.Id}", user);
            })
            .WithName("CreateUser")
            .Produces<User>(StatusCodes.Status201Created);

        group.MapDelete("/{id}", async (int id, UserDataContext db) =>
            {
                var affected = await db.User
                    .Where(model => model.Id == id)
                    .ExecuteDeleteAsync();

                return affected is 1 ? Results.Ok() : Results.NotFound();
            })
            .WithName("DeleteUser")
            .Produces<User>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);
    }
}

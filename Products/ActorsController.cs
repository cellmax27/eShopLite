using DataEntities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")] // Route de l'API : /api/Actors
public class ActorsController : ControllerBase
{
    private static List<Actor> actors = [];

    // GET : api/Actors
    [HttpGet]
    public ActionResult<IEnumerable<Actor>> GetActors()
    {
        return actors;
    }

    // GET : api/Actors/5
    [HttpGet("{id}")]
    public ActionResult<Actor> GetActor(int id)
    {
        var customer = actors.FirstOrDefault(p => p.Id == id); //recherche par age pour l'exemple
        if (customer == null)
        {
            return NotFound(); // Retourne 404 si non trouvé
        }
        return customer;
    }

    // POST : api/Actors
    [HttpPost]
    public ActionResult<Actor> PostActor(Actor customer)
    {
        actors.Add(customer);
        return CreatedAtAction(nameof(GetActor), new { id = customer.Id }, customer); // Retourne 201 Created
    }

/* [HttpPost]
[ProducesResponseType(StatusCodes.Status201Created)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
public ActionResult<Pet> Create(Pet pet)
{
    pet.Id = _petsInMemoryStore.Any() ? 
             _petsInMemoryStore.Max(p => p.Id) + 1 : 1;
    _petsInMemoryStore.Add(pet);

    return CreatedAtAction(nameof(GetById), new { id = pet.Id }, pet);
}
 */

    // PUT : api/Actors/5
    [HttpPut("{id}")]
    public IActionResult PutActor(int id, Actor actor)
    {
        if (id != actor.Id)
        {
            return BadRequest(); // Retourne 400 Bad Request si l'ID ne correspond pas
        }
        var customerExistante = actors.FirstOrDefault(p => p.Id == id);
        if (customerExistante == null)
        {
            return NotFound();
        }

        customerExistante.Name = actor.Name;
        // Mettre à jour les autres propriétés si besoin...

        return NoContent(); // Retourne 204 No Content
    }

    // DELETE : api/Actors/5
    [HttpDelete("{id}")]
    public IActionResult DeleteActor(int id)
    {
        var customer = actors.FirstOrDefault(p => p.Id == id);
        if (customer == null)
        {
            return NotFound();
        }

        actors.Remove(customer);
        return NoContent(); // Retourne 204 No Content
    }
}
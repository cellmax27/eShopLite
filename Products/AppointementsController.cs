namespace EshopController;

using DataEntities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")] // Route de l'API : /api/Appointements
public class AppointementsController : ControllerBase
{
    private static List<Appointement> appointements = []; // Liste statique pour l'exemple

    // GET : api/Appointements
    [HttpGet]
    public ActionResult<IEnumerable<Appointement>> GetAppointements()
    {
        return appointements;
    }

    // GET : api/Appointements/5
    [HttpGet("{id}")]
    public ActionResult<Appointement> GetAppointement(int id)
    {
        var appointement = appointements.FirstOrDefault(p => p.Id == id); //recherche par age pour l'exemple
        if (appointement == null)
        {
            return NotFound(); // Retourne 404 si non trouvé
        }
        return appointement;
    }

    // POST : api/Appointements
    [HttpPost]
    public ActionResult<Appointement> PostAppointement(Appointement appointement)
    {
        appointements.Add(appointement);
        return CreatedAtAction(nameof(GetAppointement), new { id = appointement.Id }, appointement); // Retourne 201 Created
    }

    // PUT : api/Appointements/5
    [HttpPut("{id}")]
    public IActionResult PutAppointement(int id, Appointement appointement)
    {
        if (id != appointement.Id)
        {
            return BadRequest(); // Retourne 400 Bad Request si l'ID ne correspond pas
        }
        var customerExistante = appointements.FirstOrDefault(p => p.Id == id);
        if (customerExistante == null)
        {
            return NotFound();
        }

        // TODO customerExistante.start = customer.start;
        // Mettre à jour les autres propriétés si besoin...

        return NoContent(); // Retourne 204 No Content
    }

    // DELETE : api/Appointements/5
    [HttpDelete("{id}")]
    public IActionResult DeleteAppointement(int id)
    {
        var appointement = appointements.FirstOrDefault(p => p.Id == id);
        if (appointement == null)
        {
            return NotFound();
        }

        appointements.Remove(appointement);
        return NoContent(); // Retourne 204 No Content
    }
}
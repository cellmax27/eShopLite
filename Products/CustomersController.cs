using DataEntities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")] // Route de l'API : /api/Customers
public class CustomersController : ControllerBase
{
    private static List<Customer> customers = [];

    // GET : api/Customers
    [HttpGet]
    public ActionResult<IEnumerable<Customer>> GetCustomers()
    {
        return customers;
    }

    // GET : api/Customers/5
    [HttpGet("{id}")]
    public ActionResult<Customer> GetCustomer(int id)
    {
        var actor = customers.FirstOrDefault(p => p.Id == id); //recherche par age pour l'exemple
        if (actor == null)
        {
            return NotFound(); // Retourne 404 si non trouvé
        }
        return actor;
    }

    // POST : api/Customers
    [HttpPost]
    public ActionResult<Customer> PostCustomer(Customer customer)
    {
        customers.Add(customer);
        return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer); // Retourne 201 Created
    }

    // PUT : api/Customers/5
    [HttpPut("{id}")]
    public IActionResult PutCustomer(int id, Customer customer)
    {
        if (id != customer.Id)
        {
            return BadRequest(); // Retourne 400 Bad Request si l'ID ne correspond pas
        }
        var actorExistante = customers.FirstOrDefault(p => p.Id == id);
        if (actorExistante == null)
        {
            return NotFound();
        }

        // TODO actorExistante.Nom = customer.Nom;
        // Mettre à jour les autres propriétés si besoin...

        return NoContent(); // Retourne 204 No Content
    }

    // DELETE : api/Customers/5
    [HttpDelete("{id}")]
    public IActionResult DeleteCustomer(int id)
    {
        var customer = customers.FirstOrDefault(p => p.Id == id);
        if (customer == null)
        {
            return NotFound();
        }

        customers.Remove(customer);
        return NoContent(); // Retourne 204 No Content
    }
}
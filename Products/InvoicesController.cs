namespace Products
{
    using DataEntities;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")] // Route de l'API : /api/Invoices
    public class InvoicesController : ControllerBase
    {
        private static List<Invoice> invoices = [];

        // GET : api/Invoices
        [HttpGet]
        public ActionResult<IEnumerable<Invoice>> GetInvoices()
        {
            return invoices;
        }

        // GET : api/Invoices/5
        [HttpGet("{id}")]
        public ActionResult<Invoice> GetInvoice(int id)
        {
            var invoice = invoices.FirstOrDefault(p => p.Id == id);
            if (invoice == null)
            {
                return NotFound(); // Retourne 404 si non trouvé
            }
            return invoice;
        }

        // POST : api/Invoices
        [HttpPost]
        public ActionResult<Invoice> PostInvoice(Invoice invoice)
        {
            invoices.Add(invoice);
            return CreatedAtAction(nameof(GetInvoice), new { id = invoice.Id }, invoice); // Retourne 201 Created
        }

        // PUT : api/Invoices/5
        [HttpPut("{id}")]
        public IActionResult PutInvoice(int id, Invoice invoice)
        {
            if (id != invoice.Id)
            {
                return BadRequest(); // Retourne 400 Bad Request si l'ID ne correspond pas
            }
            var invoiceExistante = invoices.FirstOrDefault(p => p.Id == id);
            if (invoiceExistante == null)
            {
                return NotFound();
            }

            //TODO invoiceExistante.Nom = invoice.Nom;
            // Mettre à jour les autres propriétés si besoin...

            return NoContent(); // Retourne 204 No Content
        }

        // DELETE : api/Invoices/5
        [HttpDelete("{id}")]
        public IActionResult DeleteInvoice(int id)
        {
            var invoice = invoices.FirstOrDefault(p => p.Id == id);
            if (invoice == null)
            {
                return NotFound();
            }

            invoices.Remove(invoice);
            return NoContent(); // Retourne 204 No Content
        }
    }
}
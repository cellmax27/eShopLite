namespace Products
{
    using DataEntities;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")] // Route de l'API : /api/Orders
    public class OrdersController : ControllerBase
    {
        private static List<Order> orders = []; // Liste statique pour l'exemple

        // GET : api/Orders
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            return orders;
        }

        // GET : api/Orders/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = orders.FirstOrDefault(p => p.Id == id); // recherche par ID
            if (order == null)
            {
                return NotFound(); // Retourne 404 si non trouvé
            }
            return order;
        }

        // POST : api/Orders
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            orders.Add(order);
            return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, order); // Retourne 201 Created
        }

        // PUT : api/Orders/5
        [HttpPut("{id}")]
        public IActionResult PutOrder(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest(); // Retourne 400 Bad Request si l'ID ne correspond pas
            }
            var customerExistante = orders.FirstOrDefault(p => p.Id == id);
            if (customerExistante == null)
            {
                return NotFound();
            }

            customerExistante.Name = order.Name;
            // Mettre à jour les autres propriétés si besoin...

            return NoContent(); // Retourne 204 No Content
        }

        // DELETE : api/Orders/5
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var customer = orders.FirstOrDefault(p => p.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            orders.Remove(customer);
            return NoContent(); // Retourne 204 No Content
        }
    }
}
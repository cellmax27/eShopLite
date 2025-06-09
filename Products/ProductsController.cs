namespace Products
{
    using DataEntities;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    [ApiController]
    [Route("api/[controller]")] // Route de l'API : /api/Products
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = [];

        // GET : api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return products;
        }

        // GET : api/Products/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id); // recherche par ID
            if (product == null)
            {
                return NotFound(); // Retourne 404 si non trouvé
            }
            return product;
        }

        // POST : api/Products
        [HttpPost]
        public ActionResult<Product> PostProduct(Product product)
        {
            products.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product); // Retourne 201 Created
        }

        // PUT : api/Products/5
        [HttpPut("{id}")]
        public IActionResult PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest(); // Retourne 400 Bad Request si l'ID ne correspond pas
            }
            var productExistante = products.FirstOrDefault(p => p.Id == id);
            if (productExistante == null)
            {
                return NotFound();
            }

            productExistante.Name = product.Name;
            // Mettre à jour les autres propriétés si besoin...

            return NoContent(); // Retourne 204 No Content
        }

        // DELETE : api/Products/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            products.Remove(product);
            return NoContent(); // Retourne 204 No Content
        }
    }
}

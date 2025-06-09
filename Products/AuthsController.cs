
    using DataEntities;
    using Microsoft.AspNetCore.Mvc;
    using Products.Data;
    using System.Collections.Generic;
    using System.Linq;

    //namespace Products;

    //[ApiController]
    //[Route("api/[controller]")] // Route de l'API : /api/Auths
    public class AuthsController : ControllerBase
    {/*
        private static List<User> users = [new User { Id = 2, Name = "Paul", LastName = "POP", Email = "cell", Adresse = "sdfgh", Phone = "456", Password="" },
            ];

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Logique d’authentification ici
            if (request.Name == "admin" && request.Password == "motdepasse")
                return Ok();

            return Unauthorized();
        }

        // GET : api/Auths
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetProducts()
        {
            return users;
        }

        // GET : api/Auths/5
        [HttpGet("{id}")]
        public ActionResult<User> GetProduct(int id)
        {
            var user = users.FirstOrDefault(p => p.Id == id); // recherche par ID
            if (user == null)
            {
                return NotFound(); // Retourne 404 si non trouvé
            }
            return user;
        }

        // POST : api/Auths
        [HttpPost]
        public ActionResult<User> PostProduct(User user)
        {
            users.Add(user);
            return CreatedAtAction(nameof(GetProduct), new { id = user.Id }, user); // Retourne 201 Created
        }

        // PUT : api/Auths/5
        [HttpPut("{id}")]
        public IActionResult PutProduct(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest(); // Retourne 400 Bad Request si l'ID ne correspond pas
            }
            var productExistante = users.FirstOrDefault(p => p.Id == id);
            if (productExistante == null)
            {
                return NotFound();
            }

            productExistante.Name = user.Name;
            // Mettre à jour les autres propriétés si besoin...

            return NoContent(); // Retourne 204 No Content
        }

        // DELETE : api/Auths/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var user = users.FirstOrDefault(p => p.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            users.Remove(user);
            return NoContent(); // Retourne 204 No Content
        }*/
    }


using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class LoginModel : PageModel
{
    [BindProperty]
    [Required(ErrorMessage = "Le nom est obligatoire.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Le mot de passe est obligatoire.")]
    [BindProperty]
    public string? Password { get; set; }
    public string? ErrorMessage { get; set; }

    public void OnGet() { }

    public async Task<IActionResult> OnPostAsync()
    {
        //using var client = new HttpClient();
        using var client = new HttpClient { BaseAddress = new Uri("http://localhost:5228") };

        var response = await client.PostAsJsonAsync("/auth/login", new { Name, Password });

        if (response.IsSuccessStatusCode)
        {
            // Authentification r�ussie, redirige vers la page d'accueil ou dashboard
            return RedirectToPage("/Index");
        }
        else
        {
            ErrorMessage = "Nom d'utilisateur ou mot de passe incorrect.";
            return Page();
        }
    }
}

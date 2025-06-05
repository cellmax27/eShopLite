using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Json;

public class LoginModel : PageModel
{
    [BindProperty]
    public string? Name { get; set; }
    [BindProperty]
    public string? Password { get; set; }
    public string? ErrorMessage { get; set; }

    public void OnGet() { }

    public async Task<IActionResult> OnPostAsync()
    {
        using var client = new HttpClient();
        var response = await client.PostAsJsonAsync("/auth/login", new { Name, Password });

        if (response.IsSuccessStatusCode)
        {
            // Authentification réussie, redirige vers la page d'accueil ou dashboard
            return RedirectToPage("/Index");
        }
        else
        {
            ErrorMessage = "Nom d'utilisateur ou mot de passe incorrect.";
            return Page();
        }
    }
}

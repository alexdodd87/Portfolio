using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace Portfolio.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credentials? Credentials { get; set; }

        public string Messsage { get; set; } = string.Empty;
        public void OnPost()
        {

            if (Credentials != null)
            {
                ViewData["Message"] = $"Logged in with {Credentials.Email}";
            }
        }
    }

    public record Credentials(string Email, string Password);
}

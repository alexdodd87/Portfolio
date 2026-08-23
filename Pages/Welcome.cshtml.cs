using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
    public class WelcomeModel : PageModel
    {
        public void OnGet()
        {
        }

        public string SiteName { get; set; } = "Portfolio";
    }
}

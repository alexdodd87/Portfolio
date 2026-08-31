using Portfolio.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public RegistrationInfo? Info { get; set; }

        public bool RegistrationSuccessful { get; set; } = false;

        public void OnGet()
        {
            if (TempData["Message"] is string msg && !string.IsNullOrEmpty(msg))
            {
                ViewData["Message"] = msg;
                RegistrationSuccessful = true;
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                TempData["Message"] = "Registration successful!";
                return RedirectToPage("./Login");
            }

            return Page();
        }
    }
}

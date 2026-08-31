using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
    public class ProfileModel : PageModel
    {
        [BindProperty]
        public IFormFile? Picture { get; set; }
        public async Task OnPostUploadAsync()
        {
            if (Picture != null) {
                await Picture.CopyToAsync(
                    new FileStream(Path.Combine("uploads", Guid.NewGuid().ToString()), 
                    FileMode.Create));
                ViewData["Message"] = "File uploaded successfully.";
            }
        }
    }
}

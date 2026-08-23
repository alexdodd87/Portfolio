using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages.Events
{
    public class IndexModel : PageModel
    {
        public string Category = "All";

        [BindProperty(SupportsGet = true)]
        public string Term { get; set; } = string.Empty;
        public void OnGet(string? category)
        {
            if (!string.IsNullOrEmpty(category))
            {
                Category = category;
            }

            //var search = Request.Query["search"];
            //Console.WriteLine("Search term: " + search);
        }

        // using asp-page-handler Search
        public void OnGetSearch(string term)
        {
            //var search = Request.Get["search"];
            Console.WriteLine("Search term: " + term);
        }
    }
}

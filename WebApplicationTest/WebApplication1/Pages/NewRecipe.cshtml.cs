using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplicationTest.Pages
{
    public class NewRecipe : PageModel
    {
        private readonly ILogger<NewRecipe> _logger;

        public NewRecipe(ILogger<NewRecipe> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

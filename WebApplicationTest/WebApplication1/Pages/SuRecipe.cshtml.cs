using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplicationTest.Pages
{
    public class SuRecipe : PageModel
    {
        private readonly ILogger<SuRecipe> _logger;

        public SuRecipe(ILogger<SuRecipe> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

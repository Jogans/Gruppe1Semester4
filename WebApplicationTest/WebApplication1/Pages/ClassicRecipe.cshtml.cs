using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplicationTest.Pages
{
    public class ClassicRecipe : PageModel
    {
        private readonly ILogger<ClassicRecipe> _logger;

        public ClassicRecipe(ILogger<ClassicRecipe> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

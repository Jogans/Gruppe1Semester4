using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplicationTest.Pages
{
    public class Vegi : PageModel
    {
        private readonly ILogger<Vegi> _logger;

        public Vegi(ILogger<Vegi> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

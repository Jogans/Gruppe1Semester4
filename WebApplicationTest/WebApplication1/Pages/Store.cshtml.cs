using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplicationTest.Pages
{
    public class Store : PageModel
    {
        private readonly ILogger<Store> _logger;

        public Store(ILogger<Store> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

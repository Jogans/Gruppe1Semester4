using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplicationTest.Pages
{
    public class UserPage : PageModel
    {
        private readonly ILogger<UserPage> _logger;

        public UserPage(ILogger<UserPage> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

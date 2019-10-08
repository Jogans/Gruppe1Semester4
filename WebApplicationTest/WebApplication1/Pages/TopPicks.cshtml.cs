using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplicationTest.Pages
{
    public class TopPicks : PageModel
    {
        private readonly ILogger<TopPicks> _logger;

        public TopPicks(ILogger<TopPicks> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

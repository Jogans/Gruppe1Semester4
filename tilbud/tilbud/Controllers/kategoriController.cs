using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tilbud.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tilbud.Controllers
{
    public class kategoriController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult getKategori(kategoriStreng str)
        {
            return View(str);
        }

        public IActionResult getKategori()
        {
            return View();
        }
    }
}

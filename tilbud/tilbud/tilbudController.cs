using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tilbud
{
    public class VareJson
    {
        public string tekst { get; set; }
    }

    public class tilbudController : Controller
    {
        // GET: /<controller>/

        [HttpPost]
        public ViewResult AddVare([Bind("tekst")]VareJson vare)
        {
            parseVarer.insertVare(vare.tekst);
            return View(vare);
        }
    }
}

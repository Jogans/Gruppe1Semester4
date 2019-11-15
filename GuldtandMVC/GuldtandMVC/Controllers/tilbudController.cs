using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GuldtandMVC.Controllers
{
    public class VareJson
    {
        public string tekst { get; set; }
    }

    public class tilbudController : Controller
    {
        // GET: /<controller>/

        [HttpPost]
        public void AddVare([Bind("tekst")]VareJson vare)
        {
            Models.parseVarer.insertVare(vare.tekst);

        }
    }
}
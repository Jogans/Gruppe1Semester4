using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuldtandMVC_Identity.Models;

namespace GuldtandMVC_Identity.Controllers
{
    public class VareJson
    {
        public string Tekst { get; set; }
    }

    
    
        public class TilbudController : Controller
        {
            // GET: /<controller>/

            [HttpPost]
            public void AddVare([Bind("tekst")]VareJson vare)
            {
                ParseVarer.InsertVare(vare.Tekst);
            }

            public void Update(int kode)
            {
                if (kode == 5555)
                    UpdateVarer.Update();
            }
    }

        


}


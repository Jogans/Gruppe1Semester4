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
        public string tekst { get; set; }
    }

    
    
        public class tilbudController : Controller
        {
            // GET: /<controller>/

            [HttpPost]
            public void AddVare([Bind("tekst")]VareJson vare)
            {
                ParseVarer.InsertVare(vare.tekst);
            }

            public void update(int kode)
            {
                var au = new ApplicationUser();

                if (kode == 5555)
                    UpdateVarer.Update();
            }
    }

        


}


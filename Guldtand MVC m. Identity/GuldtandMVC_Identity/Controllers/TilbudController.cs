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

        private Prj4databaseContext _context;

        public TilbudController(Prj4databaseContext context)
        {
            _context = context;
        }


        [HttpPost]
            public void AddVare([Bind("tekst")]VareJson vare)
            {
                ParseVarer.InsertVare(vare.Tekst, _context);
            }

            public void Update(int kode)
            {
                if (kode == 5555)
                    UpdateVarer.Update(_context);
            }
    }

        


}


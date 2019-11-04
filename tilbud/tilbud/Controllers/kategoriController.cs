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
            str.varer.InsertRange(0,getVarer(str.kategori));
            return View("getKategori",str);
        }

        public IActionResult getKategori()
        {
            return View("getKategori",new kategoriStreng());
        }

        public List<NyVare> getVarer(string kategori)
        {

            List<NyVare> liste = new List<NyVare>();
            using (var db = new prj4databaseContext())
            {

                var vk = db.VareKategori.Where(v => v.Kategori == kategori).ToList();
                if (vk.Count != 0)
                {
                    foreach (var varekat in vk)
                    {
                        liste.Add(db.NyVare.Where(v => v.VareId == varekat.VareId).First());
                    }

                }

            }

            return liste;
            //string str = "";
            //foreach (var vare in liste)
            //{
            //    str += vare + "<br>";
            //}
            //return str;
        }
    }
}

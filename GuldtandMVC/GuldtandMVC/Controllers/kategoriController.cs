using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GuldtandMVC.Controllers
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
            str.varer.InsertRange(0, getVarer(str.kategori));
            return View("getKategori", str);
        }

        public IActionResult getKategori()
        {
            return View("getKategori");
        }

        public IActionResult getKategori2()
        {
            return View("getKategori");
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
        }


        public string getAllVarer()
        {

            using(var db = new prj4databaseContext())
            {
                var varer = db.NyVare.ToArray();

                var json = JsonConvert.SerializeObject(varer);
                return json; 
            } 
        }
    }
}
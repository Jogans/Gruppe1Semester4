using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data;
using GuldtandMVC_Identity.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GuldtandMVC_Identity.Controllers
{
    public class kategoriController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult getKategori(KategoriStreng str)
        {
            str.varer.InsertRange(0, getVarer(str.kategori));
            return View("getKategori", str);
        }

        [HttpPost]
        public string[] insertAndGetBlacklist(string category)
        {
            var blacklist = new blacklistModel();
            return blacklist.insertandgetBlackList(category);
        }

        [HttpPost]
        public string[] getAllCategories()
        {
            var category = new Searching();
            return category.getCategoryList();
        }
        public List<Product> getVarer(string kategori)
        {

            List<Product> liste = new List<Product>();
            using (var db = new prj4databaseContext())
            {

                var vk = db.ProductCategory.Where(v => v.CategoryName == kategori).ToList();
                if (vk.Count != 0)
                {
                    foreach (var varekat in vk)
                    {
                        liste.Add(db.Product.Where(v => v.ProductId == varekat.ProductId).First());
                    }

                }

            }

            return liste;
        }


        public string getAllVarer()
        {

            using (var db = new prj4databaseContext())
            {
                var varer = db.Product.ToArray();
                var json = JsonConvert.SerializeObject(varer);
                return json;
            }
        }
    }
}
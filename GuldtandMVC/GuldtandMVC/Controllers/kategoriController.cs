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


        public string insertAndGetBlacklist(string category)
        {
            var blacklist = new blacklistModel();
            return blacklist.insertandgetBlackList(category);
        }
        public IActionResult getKategori()
        {
            return View("getKategori");
        }

        public IActionResult getKategori2()
        {
            return View("getKategori");
        }

        public string getAllCategories()
        {
            var category = new Searching();
            return category.getCategoriesAsHTML();
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

            using(var db = new prj4databaseContext())
            {
                var varer = db.Product.ToArray();
                var json = JsonConvert.SerializeObject(varer);
                return json; 
            } 
        }
    }
}
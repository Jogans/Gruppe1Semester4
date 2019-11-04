using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tilbud.Pages
{
    public class PrivacyModel : PageModel
    {
        public List<string> kategories { get; set; }

        public string choosenCategory { get; set; }
        public void OnGet()
        {
            kategories = new List<string>();
            using (var db = new prj4databaseContext())
            {
                foreach (var kategori in db.Kategori)
                {
                    kategories.Add(kategori.Kategori1);
                }
                
            }
        }

        public string getVarer()
        {
            string kategori = choosenCategory;
            List<string> liste = new List<string>();
            using (var db = new prj4databaseContext())
            {

                var vk = db.VareKategori.Where(v => v.Kategori == kategori).ToList();
                if (vk.Count != 0)
                {
                    foreach (var vare in vk)
                    {
                        liste.Add(db.Vare.Where(v => v.VareId == vare.VareId).First().Navn);
                    }
                    
                }

            }

            string str = "";
            foreach (var vare in liste)
            {
                str += vare + "<br>";
            }
            return str;
        }
    }
}
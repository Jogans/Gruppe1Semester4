using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tilbud.Model;

namespace tilbud.Pages.kategori
{
    public class getKategoriModel : PageModel
    {

        public string choosenCategory { get; set; }

        public void OnGet()
        {
            
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
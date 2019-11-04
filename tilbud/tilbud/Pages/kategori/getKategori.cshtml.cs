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

        
    }
}
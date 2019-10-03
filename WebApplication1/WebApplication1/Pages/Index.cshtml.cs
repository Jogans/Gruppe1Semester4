using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        public JToken[] adverts_ { get; set; }

        public void OnGet()
        {
            string json = System.IO.File.ReadAllText(@"C:\4. semester\json.txt");
            //Response.WriteAsync(@"<h1>Hejsa</h1>");
            JObject obj = JObject.Parse(json);
            JToken[] adverts = obj["adverts"].ToArray();
            adverts_ = adverts;
            foreach (var ad in adverts)
            {
                //("<img src\""+ad["imageUrl"]+"\"><p>");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tilbud.Pages
{
    public class IndexModel : PageModel
    {
        public String json { get; set; }
        public void OnGet()
        {

            var client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36");

            var stream = client.OpenRead("http://skeldekrojmand.dk/tilbud.txt");
            var reader = new StreamReader(stream);
            json = reader.ReadToEnd();


            //var req = WebRequest.Create(@"http://skeldekrojmand.dk/tilbud.txt");
            //req.Headers.Add("Accept - Version", "2.0");
            //req.Method = "GET";
            //using (var response = req.GetResponse())
            //using (var content = response.GetResponseStream())
            //using (var reader = new StreamReader(content))
            //{
            //    json = reader.ReadToEnd();
            //}
            /*using(WebClient client = new WebClient())
            {
                json = client.DownloadString("http://skeldekrojmand.dk/tilbud.txt");
            }*/
        }
    }
}

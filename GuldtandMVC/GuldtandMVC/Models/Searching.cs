using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC.Models
{
    public class Searching
    {
        public string searchProductsAndGetHTML(string words)
        {
            string initString = "" +
                "<html>" +
                "<table border='1'>" +
                "<tr>" +
                "<th>Navn</th>" +
                "<th>Billede</th>" +
                "<th>Pris</th>" +
                "<th>Kategori</th>" +
                "<th>Volumen</th>";
            string endString = "</table>" +
                "</html>";

            string bodystring = "";
            using(var db = new prj4databaseContext())
            {
                var result = from v in db.NyVare where v.Navn.Contains(words) select v;

                foreach(var vare in result)
                {
                    bodystring+="<tr>" +
                        "<td>"+vare.Navn+"</td>"+
                        "<td>"+"<img src'"+vare.ImgSrc+"'/>"+"</td>" +
                        "<td>"+vare.Pris+"</td>" +
                        "<td>"+"</td>" +
                        "<td>"+vare.Volumen+"</td>" +
                        "</tr>";
                }
            }
            return initString+bodystring+endString;
        }

        
    }
}

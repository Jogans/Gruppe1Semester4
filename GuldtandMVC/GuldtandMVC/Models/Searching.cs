﻿using Microsoft.AspNetCore.Mvc;
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
                var result = from v in db.Product where v.Name.Contains(words) select v;

                foreach(var vare in result)
                {
                    bodystring+="<tr>" +
                        "<td>"+vare.Name+"</td>"+
                        "<td>"+"<img width='10%' src='"+vare.ImgSrc+"'/>"+"</td>" +
                        "<td>"+vare.Price+"</td>" +
                        "<td>"+"</td>" +
                        "<td>"+vare.Volume+"</td>" +
                        "</tr>";
                }
            }
            return initString+bodystring+endString;
        }

        
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC.Models
{
    public class Searching

    {

        public string[] getCategoryList()
        {
            using (var db = new prj4databaseContext())
            {
                var categoryList = (from c in db.Category select c.CategoryName).ToArray();
                return categoryList;
            }
        }
        public string getCategoriesAsHTML()
        {
            //
            string initString = "<select v-model='kategoriParameter' id='category'>";
            string bodyString = "";

            //string[] categoryArray;
            using(var db = new prj4databaseContext())
            {
                var categoryList = (from c in db.Category select c.CategoryName).ToList();

                foreach (var category in categoryList)
                {
                    bodyString += "<option value='" + category + "'>" + category + "</option>";
                }
            }
            //</select>
            string endString = "</select>";

            return initString + bodyString + endString;
        }
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
                    var category = db.ProductCategory.Where(k => k.ProductId == vare.ProductId).First().CategoryName;
                    
                    bodystring+="<tr>" +
                        "<td>"+vare.Name+"</td>"+
                        "<td>"+"<img width='10%' src='"+vare.ImgSrc+"'/>"+"</td>" +
                        "<td>"+vare.Price+" kr.</td>" +
                        "<td>"+category+"</td>" +
                        "<td>"+vare.Volume+" ml.</td>" +
                        "</tr>";
                }
            }
            return initString+bodystring+endString;
        }

        
    }
}

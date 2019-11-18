using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data;

namespace GuldtandMVC_Identity.Models
{
    public class AddHTMLToRecipe
    {
        public string ShowRecipe(string words)
        {
            
            string initString = "" +
                                "<html>";
            string endString = "</html>";

            string bodystring = "";
            string ingrediensstring = "";
            string directionsstring = "";
            int steps = 1;
            using (var db = new prj4databaseContext())
            {
                var result = from v in db.OpenHours select v;

                foreach (var recipe in result)
                {
                    bodystring += "<h1>" + recipe.RetailChain + "</h1>";
                    //              "<div class='recepie'>" +
                    //              "<div class='ingredienser'>" +
                    //              "<p class='p2'><span class='s1'>" + recipe.CookTime + " min tilberednings tid" +
                    //              "<br></span>Til 4 personer</p>" +
                    //              "<div class='image'>" +
                    //              "< img src = '" + recipe.img + "' />" +
                    //              "</div>" +
                    //              "<br style='clear: both' />" +
                    //              "<p class='p3'><strong>Ingredienser</strong></p>" +
                    //              "<div class='i1'>" +
                    //              "<ul";
                    //foreach (var ingrediens in recipe.IngredientList.Ingredient)
                    //{
                    //    ingrediensstring += "<li class='p4'>" + recipe.IngredientList.Ingredient.Count + " " + recipe.IngredientList.Ingredient + "</li>";
                    //}

                    //bodystring += ingrediensstring;
                    //bodystring += "</ul>" +
                    //              "</div>" +
                    //              "<br style='clear:both' />" +
                    //              "<div class='f1'>" +
                    //              "<h3>Fremgangsmåde</h3>";
                    //foreach (var direction in recipe.DirectionList.Direction)
                    //{
                    //    directionsstring += "<p>" + steps++ + "." + recipe.DirectionList.Direction + "</p>";
                    //}

                    //bodystring += directionsstring;
                    //bodystring += "</div>" +
                    //              "</div>" +
                    //              "</div>";
                }
            }
            return initString + bodystring + endString;
        }

    }
}

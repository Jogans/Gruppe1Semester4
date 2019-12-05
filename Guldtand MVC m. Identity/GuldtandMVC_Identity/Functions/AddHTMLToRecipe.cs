using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data;
using GuldtandMVC_Identity.Data.Queries;
using GuldtandMVC_Identity.Data.Repositories;

namespace GuldtandMVC_Identity.Models
{
    public class AddHTMLToRecipe
    {
        //public string ShowRecipeFullView(string words)
        //{

        //    string initString = "" +
        //                        "<html>";
        //    string endString = "</html>";

        //    string bodystring = "";
        //    string ingrediensstring = "";
        //    string directionsstring = "";
        //    int steps = 1;
        //    using (var db = new prj4databaseContext())
        //    {
        //        var result = from v in db.Recipe where v.Name.Contains(words) select v;

        //        foreach (var recipe in result)
        //        {
        //            bodystring = "";
        //            ingrediensstring = "";
        //            directionsstring = "";
        //            bodystring += "<h1>" + recipe.Name + "</h1>" +
        //            "<div class='recepie'>" +
        //                "<div class='ingredienser'>" +
        //                "<p class='p2'><span class='s1'>" + recipe.CookTime + " min tilberednings tid" +
        //            "<br></span>Til 4 personer</p>" +
        //                "<div class='image'>" +
        //                "<img src = '" + recipe.ImgSrc + "' />" +
        //            "</div>" +
        //                "<br style='clear: both' />" +
        //                "<p class='p3'><strong>Ingredienser</strong></p>" +
        //            "<div class='i1'>" +
        //            "<ul";
        //            foreach (var ingrediens in db.Ingredient.Where(i => i.IngredientList.RecipeId == recipe.RecipeId))
        //            {
        //                ingrediensstring += "<li class='p4'>" + ingrediens.Amount + ingrediens.AmountUnit + " " + ingrediens.Name + "</li>";
        //            }

        //            bodystring += ingrediensstring;
        //            bodystring += "</ul>" +
        //                          "</div>" +
        //                          "<br style='clear:both' />" +
        //                          "<div class='f1'>" +
        //                          "<h3>Fremgangsmåde</h3>" +
        //                          "<div class='i2'>" +
        //                          "<ul";
        //            foreach (var direction in db.Directions.Where(d => d.RecipeId == recipe.RecipeId))
        //            {
        //                directionsstring += "<li class='p5'>" + direction.Description + "</li>";
        //            }

        //            bodystring += directionsstring;
        //            bodystring += "</ul>" +
        //                          "</div>" +
        //                          "</div>" +
        //                          "</div>";
        //        }
        //    }
        //    return initString + bodystring + endString;
        //}

        public async Task<string> ShowRecipeFullView(string words)
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
                RecipeQuery query = new RecipeQuery
                {
                    LoadIngredientList = true,
                    LoadRecipeCategory = true,
                    SearchRecipe = words,
                    NumberOfRecipes = 1
                };
                var result = await query.Execute(db);

                foreach (var recipe in result)
                {
                    bodystring = "";
                    ingrediensstring = "";
                    directionsstring = "";
                    bodystring += "<h1>" + recipe.Name + "</h1>" +
                    "<div class='recepie'>" +
                        "<div class='ingredienser'>" +
                        "<p class='p2'><span class='s1'>" + recipe.CookTime + " min tilberednings tid" +
                    "<br></span>Til 4 personer</p>" +
                        "<div class='image'>" +
                        "<img src = '" + recipe.ImgSrc + "' height='400' width='700'/>" +
                    "</div>" +
                        "<br style='clear: both' />" +
                        "<h3 class='p3'><strong>Fremgangsmåde</strong></h3>" +
                    "<div class='i1'>" + "<ul>";

                    foreach (var direction in recipe.Directions)
                    {
                        directionsstring += "<li class='p5'>" + direction.Description + "</li>";
                    }

                    bodystring += directionsstring;
                    bodystring += "</ul>" +
                                  "<h3><strong>Ingredienser</strong></h3>" +
                                  "<ul>";
                    foreach (var ingredient in recipe.IngredientList.Ingredient)
                    {
                        ingrediensstring += "<li>" + ingredient.Amount + ingredient.AmountUnit + " " + ingredient.Name + "</li>";
                    }

                    bodystring += ingrediensstring;
                    bodystring += "</ul>" +
                                  "</div>" +
                                  "<br style='clear:both' />" +
                                  "<div class='f1'>" +
                                  "<div class='i2'>" +
                                  "<ul>" +
                                  "</div>" +
                                  "</div>" +
                                  "</div>";
                }
            }
            return initString + bodystring + endString;
        }

        public async Task<string> ShowRecipeSmallViewAsync()
        {

            string initString = "" + "<html>";
            string style = "<head>" +
                           "<style>" +

                           ".viewOfRecepie{" +
                           "width: 900px;" +
                           "height: 200px;" +
                           "border: 2px solid;" +
                           "padding: 2px;" +
                           "margin: 20px;}" +

                           ".img1{" +
                           "display: block;" +
                           "position: absolute;" +
                           "width: 350px;" +
                           "height: 200px;}" +

                           ".textForPrice{" +
                           "display: block;" +
                           "position: relative;" +
                           "float: left;" +
                           "margin-left: 355px;" +
                           "font-size: 20px;}" +

                           "</style>" +
                           "</head> ";
            string endString = "</html>";

            string bodystring = "";

            HTMLCalculator RabatPris = new HTMLCalculator();

            using (var db = new prj4databaseContext())
            {
                RecipeQuery query = new RecipeQuery
                {
                    NumberOfRecipes = 5
                };

                var result = await query.Execute(db);

                foreach (var recipe in result)
                {
                    bodystring += "<div class='viewOfRecepie'>" +
                                  "<div class='imageOfRecepie'>" +
                                  "<a href='/#/Recepie/" + recipe.Name.Replace(" ", string.Empty).Replace("æ", string.Empty).Replace("ø", string.Empty).Replace("å", string.Empty) + "'>" +
                                  "<img class='img1' src='" + recipe.ImgSrc + "' alt='recpieImg'></a>" +
                                  "</div>" +
                                  "<div class='textForPrice'>" +
                                  "<div style='font-size: 25px;'>" +
                                  "<a href='/#/Recepie/" + recipe.Name.Replace(" ", string.Empty).Replace("æ", string.Empty).Replace("ø", string.Empty).Replace("å", string.Empty) + "'>" +
                                  recipe.Name +
                                  "</a>" +
                                  "<br />" +
                                  "</div>" +
                                  "Original pris: " + recipe.Price + "kr." + "<br />" +
                                  "Pris med rabat: " + await RabatPris.totalPrice("marcus") + "kr." + "<br />" +
                                  "Laveste mulige pris: " + recipe.Price + "kr." + "<br />" +
                                  "</div>" +
                                  "</div>";
                }
            }
            return initString + style + bodystring + endString;
        }

    }
}


// "<div class='recepie'>" +
//    "<div class='ingredienser'>" +
//    "<p class='p2'><span class='s1'>" + recipe.CookTime + " min tilberednings tid" +
//"<br></span>Til 4 personer</p>" +
//    "<div class='image'>" +
//    "<img src = '" + recipe.ImgSrc + "' />" +
//"</div>" +
//    "<br style='clear: both' />" +
//    "<p class='p3'><strong>Ingredienser</strong></p>" +
//"<div class='i1'>" +
//"<ul";
//foreach (var ingrediens in db.Ingredient.Where(i => i.IngredientList.RecipeId == recipe.RecipeId))
//{
//    ingrediensstring += "<li class='p4'>" + ingrediens.Amount + ingrediens.AmountUnit + " " + ingrediens.Name + "</li>";
//}

//bodystring += ingrediensstring;
//bodystring += "</ul>" +
//              "</div>" +
//              "<br style='clear:both' />" +
//              "<div class='f1'>" +
//              "<h3>Fremgangsmåde</h3>" +
//              "<div class='i2'>" +
//              "<ul";
//foreach (var direction in db.Directions.Where(d => d.RecipeId == recipe.RecipeId))
//{
//    directionsstring += "<li class='p5'>" + direction.Description + "</li>";
//}
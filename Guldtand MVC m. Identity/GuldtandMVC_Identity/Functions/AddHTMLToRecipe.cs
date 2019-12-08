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
       

        public async Task<string> ShowRecipeFullView(string words, double antal)
        {
            string initString = "" +
                                "<html>";
            string endString = "</html>";

            string bodystring = "";

            string[] storeSplit = new string[8];

            antal = antal / 4;

            int steps = 1;
            using (var db = new prj4databaseContext())
            {
                RecipeQuery query = new RecipeQuery
                {
                    LoadIngredientList = true,
                    LoadRecipeCategory = true,
                    SearchRecipe = words,
                    NumberOfRecipes = 1,

                };
                var result = await query.Execute(db);


                foreach (var recipe in result)
                {
                    bodystring = "";
                    string ingrediensstring = "";
                    string directionsstring = "";
                    bodystring += "<h1>" + recipe.Name + "</h1>" +
                    "<div class='recepie'>" +
                        "<div class='ingredienser'>" +
                        "<p class='p2'><span class='s1'>" + recipe.CookTime + " min tilberednings tid" +
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
                        ingrediensstring += "<li class='p6'>" + (ingredient.Amount * antal) + ingredient.AmountUnit + " " + ingredient.Name +
                                            "</li>";
                    }

                    bodystring += ingrediensstring;
                    bodystring += "</ul>" +
                                  "</div>" +
                                  "<br style='clear:both' />" +
                                  "<ul>" +
                                  "</div>";
                }
            }
            return initString + bodystring + endString;
        }

        public async Task<string> GenerateShoppingCart(string words, string stores)
        {
            string initString = "" +
                    "<html>";
            string endString = "</html>";

            string bodystring = "";

            string[] storeSplit = new string[8];

            if (stores != null)
            {
                storeSplit = stores.Split(';', StringSplitOptions.RemoveEmptyEntries);
            }

            int steps = 1;
            using (var db = new prj4databaseContext())
            {
                RecipeQuery query = new RecipeQuery
                {
                    LoadIngredientList = true,
                    LoadRecipeCategory = true,
                    SearchRecipe = words,
                    NumberOfRecipes = 1,
                    Stores = storeSplit

                };
                var result = await query.Execute(db);

                foreach (var recipe in result)
                {
                    bodystring = "";
                    string ingrediensstring = "";
                    bodystring += "<h3><strong>Indkøbsliste</strong></h3>";

                    bodystring += "<ul>";
                    foreach (var ingredient in recipe.IngredientList.Ingredient)
                    {
                        ingrediensstring += "<li class='p6'>" + ingredient.Name + " - " + " Købes i " + ingredient.Product.RetailChain.Name + " for " +
                                            ingredient.Product.Price + " kr. " + "Test: " + ingredient.Product.Name + "</li>";
                    }

                    bodystring += ingrediensstring;
                    bodystring += "</ul>" +
                                  "</div>" +
                                  "<br style='clear:both' />" +
                                  "<ul>" +
                                  "</div>";
                }
            }
            return initString + bodystring + endString;
        }

        public async Task<string> ShowRecipeSmallViewAsync(string stores, int count)
        {

            string initString = "" + "<html>";
            string style = "<head>" +
                           "<style>" +

                           ".viewOfRecepie{" +
                           "width: 60%;" +
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
            HTMLCalculator NormalPris = new HTMLCalculator();

            string[] storeSplit = new string[8];
            string[] storeSplitfake = new string[8];

            if (stores != null)
            {
                storeSplit = stores.Split(';', StringSplitOptions.RemoveEmptyEntries);
            }

            using (var db = new prj4databaseContext())
            {
                RecipeQuery query = new RecipeQuery
                {
                    NumberOfRecipes = count,
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
                                  "Original pris: " + await NormalPris.NormalPrice(recipe.Name, storeSplit) + "kr." + " <br />" +
                                  "Pris med rabat: " + await RabatPris.TotalPrice(recipe.Name, storeSplit) + "kr." + "<br />" +
                                  "Laveste mulige pris: " + await RabatPris.TotalPrice(recipe.Name, storeSplitfake) + "kr." + "<br />" +
                                  "</div>" +
                                  "</div>";
                }
            }
            return initString + style + bodystring + endString;
        }

        public async Task<string> ShowRecipeSmallViewSearchAsync(string word, string stores)
        {

            string initString = "" + "<html>";
            string style = "<head>" +
                           "<style>" +

                           ".viewOfRecepie{" +
                           "width: 60%;" +
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
            HTMLCalculator NormalPris = new HTMLCalculator();

            string[] storeSplit = new string[8];
            string[] storeSplitfake = new string[8];

            if (stores != null)
            {
                storeSplit = stores.Split(';', StringSplitOptions.RemoveEmptyEntries);
            }

            using (var db = new prj4databaseContext())
            {
                RecipeQuery query = new RecipeQuery
                {
                    SearchRecipe = word,
                    NumberOfRecipes = 5
                };



                var result = await query.Execute(db);


                if (result.Count() == 0)
                {
                    return "Ingen opskrift fundet";
                }

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
                                  "Original pris: " + await NormalPris.NormalPrice(recipe.Name, storeSplit) + "kr." + " <br />" +
                                  "Pris med rabat: " + await RabatPris.TotalPrice(recipe.Name, storeSplit) + "kr." + "<br />" +
                                  "Laveste mulige pris: " + await RabatPris.TotalPrice(recipe.Name, storeSplitfake) + "kr." + "<br />" +
                                  "</div>" +
                                  "</div>";
                }
            }
            return initString + style + bodystring + endString;
        }

    }
}
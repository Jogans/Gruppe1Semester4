using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuldtandMVC_Identity.Models;
using iTextSharp.tool.xml.html;
using com.sun.org.apache.xerces.@internal.parsers;
using GuldtandMVC_Identity.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Identity;
using GuldtandMVC_Identity.Areas.Identity.Pages.Account;
using java.net;
using jdk.nashorn.@internal.ir;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;

namespace GuldtandMVC_Identity.Controllers
{
    public class RecipeController : ControllerBase
    {

        public Task<string> viewASpeceficRecipe(string words, double antal)
        {
            var recipe = new AddHTMLToRecipe();

            return recipe.ShowRecipeFullView(words, antal);
        }

        public Task<string> getShoppingCart(string words, string stores)
        {
            var recipe = new AddHTMLToRecipe();

            return recipe.GenerateShoppingCart(words, stores);
        }

        public Task<string> viewForSmallRecipe(string stores)
        {
            var recipe = new AddHTMLToRecipe();
            return recipe.ShowRecipeSmallViewAsync(stores);
        }

        public Task<string> viewForSmallRecipeSearch(string word, string stores)
        {
            var recipe = new AddHTMLToRecipe();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Task<string> result = recipe.ShowRecipeSmallViewSearchAsync(word, stores);
            watch.Stop();
            Console.WriteLine($"Færdig med viewforsmall {watch.Elapsed}");
            return result;
        }


    }
}
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

        public Task<string> viewASpeceficRecipe(string words, double count)
        {
            var recipe = new AddHTMLToRecipe();

            return recipe.ShowRecipeFullView(words, count);
        }

        public Task<string> getShoppingCart(string words, string stores)
        {
            var recipe = new AddHTMLToRecipe();

            return recipe.GenerateShoppingCart(words, stores);
        }

        public Task<string> viewForSmallRecipe(string stores, int count)
        {
            var recipe = new AddHTMLToRecipe();
            return recipe.ShowRecipeSmallViewAsync(stores, count);
        }

        public Task<string> viewForSmallRecipeSearch(string word, string stores)
        {
            var recipe = new AddHTMLToRecipe();
            Task<string> result = recipe.ShowRecipeSmallViewSearchAsync(word, stores);
            return result;
        }
    }
}
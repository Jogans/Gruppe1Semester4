using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuldtandMVC_Identity.Models;
using com.sun.org.apache.xerces.@internal.parsers;
using GuldtandMVC_Identity.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Identity;
using java.net;
using jdk.nashorn.@internal.ir;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace GuldtandMVC_Identity.Controllers
{
    public class RecipeController : ControllerBase
    {

        public Task<string> ViewASpeceficRecipe(string words, double count)
        {
            var recipe = new AddHTMLToRecipe();

            return recipe.ShowRecipeFullView(words, count);
        }

        public Task<string> GetShoppingCart(string words, string stores)
        {
            var recipe = new AddHTMLToRecipe();

            return recipe.GenerateShoppingCart(words, stores);
        }

        public Task<string> ViewForSmallRecipe(string stores, int count)
        {
            var recipe = new AddHTMLToRecipe();
            return recipe.ShowRecipeSmallViewAsync(stores, count);
        }

        public Task<string> ViewForSmallRecipeSearch(string word, string stores)
        {
            var recipe = new AddHTMLToRecipe();
            Task<string> result = recipe.ShowRecipeSmallViewSearchAsync(word, stores);
            return result;
        }

        [Authorize]
        public Task<string> RecipeCreate(string name, int prepareTime, string description, string ingridientName, string ingridientAmount, string ingridientUnit, string imgUrl)
        {
            var createRecipe = new CreateRecipeFromVue();

            return createRecipe.CreateRecipeToDatabase(name, prepareTime, description, ingridientName, ingridientAmount, ingridientUnit, imgUrl);
        }
    }
}
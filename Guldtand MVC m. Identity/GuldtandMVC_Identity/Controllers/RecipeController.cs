using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuldtandMVC_Identity.Models;
using GuldtandMVC_Identity.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace GuldtandMVC_Identity.Controllers
{
    public class RecipeController : ControllerBase
    {
        private Prj4databaseContext _context;

        public RecipeController(Prj4databaseContext context)
        {
            _context = context;
        }

        public Task<string> ViewASpeceficRecipe(string words, double count)
        {
            var recipe = new AddHtmlToRecipe();

            return recipe.ShowRecipeFullView(words, count, _context);
        }

        public Task<string> GetShoppingCart(string words, string stores)
        {
            var recipe = new AddHtmlToRecipe();

            return recipe.GenerateShoppingCart(words, stores, _context);
        }

        public Task<string> ViewForSmallRecipe(string stores, int count)
        {
            var recipe = new AddHtmlToRecipe();
            return recipe.ShowRecipeSmallViewAsync(stores, count, _context);
        }

        public Task<string> ViewForSmallRecipeSearch(string word, string stores)
        {
            var recipe = new AddHtmlToRecipe();
            Task<string> result = recipe.ShowRecipeSmallViewSearchAsync(word, stores, _context);
            return result;
        }

        [Authorize]
        public Task<string> RecipeCreate(string name, int prepareTime, string description, string ingridientName, string ingridientAmount, string ingridientUnit, string imgUrl)
        {

            var createRecipe = new CreateRecipeFromVue();

            return createRecipe.CreateRecipeToDatabase(name, prepareTime, description, ingridientName, ingridientAmount, ingridientUnit, imgUrl, _context);
        }
    }
}
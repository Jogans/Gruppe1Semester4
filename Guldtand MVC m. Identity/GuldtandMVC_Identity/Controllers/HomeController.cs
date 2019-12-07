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
    public class HomeController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;


        public string searchProducts(string words)
        {
            var search = new Searching();

            return search.searchProductsAndGetHTML(words);

        }
        [Authorize]
        [HttpPost]
        public Task<string> recepieCreateTest(string name, int prepareTime, string description, string ingridientName, string ingridientAmount, string ingridientUnit, string imgUrl)
        {
            var createRecepie = new CreateRecepieFromVue();

            return createRecepie.CreateRecipeToDatabase(name, prepareTime, description, ingridientName, ingridientAmount, ingridientUnit, imgUrl);
        }

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

            return recipe.ShowRecipeSmallViewSearchAsync(word, stores);
        }

        //public Task<double> viewTotalPrice(string words)
        //{
        //    var totalPrice = new HTMLCalculator();

        //    return totalPrice.TotalPrice(words);

        //}

        public async Task<IActionResult> chooseStoresFromSidebar(string stores)
        {
            HttpContext.Response.Cookies.Append(
                "sejt",
                "hej",
                new CookieOptions()
                {
                    Expires = DateTime.Now.AddHours(3),
                    HttpOnly = false,
                    Secure = true,
                    IsEssential = true
                }
                );
            return Ok();
        }

        public Task<string> viewNormalPrice(string words, string stores)
        {
            var normalPrice = new HTMLCalculator();

            string[] storeSplit = new string[8];

            if (stores != null)
            {
                storeSplit = stores.Split(';', StringSplitOptions.RemoveEmptyEntries);
            }


            return normalPrice.DoAsTold(words, storeSplit);
        }

        public string searchRecipesByName(string words)
        {
            return "";
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
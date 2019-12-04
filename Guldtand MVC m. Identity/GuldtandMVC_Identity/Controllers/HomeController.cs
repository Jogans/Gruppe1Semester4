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
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;

namespace GuldtandMVC_Identity.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string searchProducts(string words)
        {
            var search = new Searching();

            return search.searchProductsAndGetHTML(words);

        }

        public string recepieCreateTest(string name, int prepareTime, string description, string ingridients, string imgUrl)
        {
            var testCreate = new CreateRecepieFromVue();

            return testCreate.testCreateRecepieFunc(name, prepareTime, description, ingridients, imgUrl);
        }

        public string viewASpeceficRecipe(string words)
        {
            var recipe = new AddHTMLToRecipe();

            return recipe.ShowRecipeFullView(words);
        }

        public string viewForSmallRecipe(string words)
        {
            var recipe = new AddHTMLToRecipe();

            return recipe.ShowRecipeSmallView(words).Result;
        }

        public Task<double> viewTotalPrice(string words)
        {
            var totalPrice = new HTMLCalculator();

            return totalPrice.totalPrice(words);

        }

        public string searchRecipesByName(string words)
        {
            return "";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
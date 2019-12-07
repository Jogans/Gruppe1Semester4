﻿using System;
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
    public class HomeController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        public string storesChoosen { get; set; } = "Not set yet ";

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

        public Task<string> recepieCreateTest(string name, int prepareTime, string description, string ingridientName, string ingridientAmount, string ingridientUnit, string imgUrl)
        {
            var testCreate = new CreateRecepieFromVue();

            return testCreate.CreateRecipeToDatabase(name, prepareTime, description, ingridientName, ingridientAmount, ingridientUnit, imgUrl);
        }

        public Task<string> viewASpeceficRecipe(string words, string stores)
        {

            var recipe = new AddHTMLToRecipe();

            return recipe.ShowRecipeFullView(words, stores);
        }

        public Task<string> viewForSmallRecipe(string stores)
        {
            var recipe = new AddHTMLToRecipe();

            return recipe.ShowRecipeSmallViewAsync(stores);
        }

        public Task<double> viewTotalPrice(string words)
        {
            var totalPrice = new HTMLCalculator();

            return totalPrice.TotalPrice(words);

        }

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

        public Task<double> viewNormalPrice(string words)
        {
            var normalPrice = new HTMLCalculator();

            return normalPrice.NormalPrice(words);
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
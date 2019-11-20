using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using com.sun.org.apache.bcel.@internal.generic;
using GuldtandMVC_Identity.Data;
using jdk.nashorn.@internal.ir;
using GuldtandMVC_Identity.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Identity;
using GuldtandMVC_Identity.Areas.Identity.Pages.Account;
using Microsoft.Extensions.Logging;

namespace GuldtandMVC_Identity.Models
{
    public class HTMLCalculator
    {
        public double totalPrice(string word)
        {
            string initString = "" + "<html>";
            string endString = "</html>";
            string bodyString = "";

            double totalPrice = 0;

            using (var db = new prj4databaseContext())
            {
                var result = from v in db.Recipe where v.Name.Contains(word) select v;

                foreach (var recipe in result)
                {
                    foreach (var ingredient in db.Ingredient.Where(i => i.IngredientList.RecipeId == recipe.RecipeId))
                    {
                        foreach (var product in db.Product.Where(p => p.ProductId == ingredient.ProductId))
                        {
                            totalPrice += product.Price;
                        }
                    }
                }
                return totalPrice;
            }
        }
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        //public string testLoginFunc(string login, string password)
        //{
        //    //LoginModel test = new LoginModel(_signInManager, _logger);
        //    //test.Input.Email = login;
        //    //test.Input.Password = password;

        //    string initString = "" +
        //                        "<html>";
        //    string endString = "</html>";

        //    string bodystring = "";

        //    bodystring += "<h1>" + "Teststring output: " + login + "</h1>";

        //    return initString + bodystring + endString;;
        //}

    }


}

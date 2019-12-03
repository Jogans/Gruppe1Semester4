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
using GuldtandMVC_Identity.Data.Queries;
using GuldtandMVC_Identity.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GuldtandMVC_Identity.Models
{
    public class HTMLCalculator
    {
        public async Task<double> totalPrice(string word)
        {
            string initString = "" + "<html>";
            string endString = "</html>";
            string bodyString = "";

            double totalPrice = 0;

            using (var db = new prj4databaseContext())
            {
                RecipeQuery recipequery = new RecipeQuery
                {
                    SearchRecipe = word,
                    LoadIngredientList = true,
                    NumberOfRecipes = 1
                };
                RecipeRepository inReciperepository = new RecipeRepository(db);
                var result = await inReciperepository.Get(recipequery);

                foreach (var recipe in result)
                {
                    //take all ingredients in the ingredientlist
                    foreach (var ingredient in recipe.IngredientList.Ingredient)
                    {
                        //foreach (var product in )
                        //{
                        //    totalPrice += product.Price;
                        //}
                    }
                }
                return totalPrice;
            }
        }
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

    }


}

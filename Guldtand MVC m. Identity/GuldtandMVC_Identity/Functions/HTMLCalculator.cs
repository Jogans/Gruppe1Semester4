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
using GuldtandMVC_Identity.Data;

namespace GuldtandMVC_Identity.Models
{
    public class HTMLCalculator
    {
        public async Task<double> normalPrice(string word)
        {
            string initString = "" + "<html>";
            string endString = "</html>";
            string bodyString = "";

            double normalPrice = 0;

            using (var db = new prj4databaseContext())
            {
                RecipeQuery recipequery = new RecipeQuery
                {
                    SearchRecipe = word,
                    LoadIngredientList = true,
                    NumberOfRecipes = 1
                };

                RecipeRepository recipeRepository = new RecipeRepository(db);
                var recepylist = await recipeRepository.Get(recipequery);
                ProductRepository productRepository = new ProductRepository(db);
                var products = await productRepository.Get(new ProductQuery());

                ProductQuery query = new ProductQuery();
                int productLifeTime = Int32.Parse(query.ValidToDate);
                if (productLifeTime > 2049)
                {
                    foreach (var recipe in recepylist)
                    {
                        //take all ingredients in the ingredientlist
                        foreach (var ingredient in recipe.IngredientList.Ingredient)
                        {
                            foreach (var product in products)
                            {
                                normalPrice += product.Price;

                            }
                        }
                    }
                    return normalPrice;
                }
                else
                {
                    return 0.0;
                }
            }
        }

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
         
                RecipeRepository recipeRepository = new RecipeRepository(db);
                var recepylist = await recipeRepository.Get(recipequery);
                ProductRepository productRepository = new ProductRepository(db);
                var products = await productRepository.Get(new ProductQuery());

                foreach (var recipe in recepylist)
                {
                    //take all ingredients in the ingredientlist
                    foreach (var ingredient in recipe.IngredientList.Ingredient)
                    {
                        foreach (var product in products)
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

    }


}

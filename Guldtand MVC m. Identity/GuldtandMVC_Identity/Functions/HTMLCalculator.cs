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
using GuldtandMVC_Identity.Functions;

namespace GuldtandMVC_Identity.Models
{
    public class HTMLCalculator : IHTMLCalculator
    {
        public async Task<double> NormalPrice(string word)
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
                ProductQuery query = new ProductQuery
                {
                    ValidToDate = "2050"
                };
                var listProduct = await query.Execute(db);

                RecipeRepository recipeRepository = new RecipeRepository(db);
                var recepylist = await recipeRepository.Get(recipequery);
                ProductRepository productRepository = new ProductRepository(db);
                var products = await productRepository.Get(query);


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
        }

        public async Task<double> TotalPrice(string word)
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

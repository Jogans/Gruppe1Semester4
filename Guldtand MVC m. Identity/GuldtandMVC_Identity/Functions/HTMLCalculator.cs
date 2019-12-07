using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public async Task<double> NormalPrice(string word, string[] stores)
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
                    LoadRecipeCategory = true,
                    NumberOfRecipes = 1,
                    Stores = stores

                };
                ProductQuery query = new ProductQuery
                {
                    ValidToDate = "2050",
                    NumberOfProducts = 1,
                    Stores = stores
                };
                var listProduct = await query.Execute(db);

                RecipeRepository recipeRepository = new RecipeRepository(db);
                var recepylist = await recipeRepository.Get(recipequery);
                ProductRepository productRepository = new ProductRepository(db);


                foreach (var recipe in recepylist)
                {
                    //take all ingredients in the ingredientlist
                    foreach (var ingredient in recipe.IngredientList.Ingredient)
                    {
                        
                        ProductQuery productQuery = new ProductQuery
                        {
                            SearchName = ingredient.Name,
                            NumberOfProducts = 1,
                            LoadRetailChain = true,
                            ValidToDate = "2050",
                            Stores = stores
                        };
                        var product = await productQuery.Execute(db);
                        if (product.Any())
                        {
                            ingredient.ProductId = product.First().ProductId;
                            normalPrice += ingredient.Product.Price;
                        }
                      
                    }
                }
                return normalPrice;

            }
            
        }



        public async Task<string> DoAsTold(string word, string[] stores)
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
                    LoadRecipeCategory = true,
                    NumberOfRecipes = 1,
                    Stores = stores

                };
                DateTime validToDateTime = new DateTime(2050,12,1,0,0,0);


                string datestring;

                datestring = "2050-12-01 00:00:00.000";

                ProductQuery query = new ProductQuery
                {
                    ValidToDate = datestring,
                    NumberOfProducts = 1,
                    Stores = stores
                };

                string testString = "";

                var listProduct = await query.Execute(db);

                RecipeRepository recipeRepository = new RecipeRepository(db);
                var recepylist = await recipeRepository.Get(recipequery);
                ProductRepository productRepository = new ProductRepository(db);


                foreach (var recipe in recepylist)
                {
                    //take all ingredients in the ingredientlist
                    foreach (var ingredient in recipe.IngredientList.Ingredient)
                    {

                        ProductQuery productQuery = new ProductQuery
                        {
                            SearchName = ingredient.Name,
                            NumberOfProducts = 1,
                            LoadRetailChain = true,
                            ValidToDate = datestring,
                            Stores = stores
                        };
                        var product = await productQuery.Execute(db);
                        if (product.Any())
                        {
                            ingredient.ProductId = product.First().ProductId;
                            normalPrice += ingredient.Product.Price;
                            testString += ingredient.Product.Name + " // " + ingredient.Product.Price + " // " +
                                          ingredient.Product.ValidTo + " // ";
                        }

                    }
                }

                testString += normalPrice;
                return testString;

            }

        }


        public async Task<double> TotalPrice(string word, string[] stores)
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
                    LoadRecipeCategory = true,
                    NumberOfRecipes = 1,
                    Stores = stores
                };
                ProductQuery query = new ProductQuery();
            

                RecipeRepository recipeRepository = new RecipeRepository(db);
                var recepylist = await recipeRepository.Get(recipequery);
                ProductRepository productRepository = new ProductRepository(db);
                var listProduct = await query.Execute(db);


                foreach (var recipe in recepylist)
                {
                    //take all ingredients in the ingredientlist
                    foreach (var ingredient in recipe.IngredientList.Ingredient)
                    {

                        ProductQuery productQuery = new ProductQuery
                        {
                            SearchName = ingredient.Name,
                            NumberOfProducts = 1,
                            LoadRetailChain = true,
                        };
                        var product = await productQuery.Execute(db);
                        if (product.Any())
                        {
                            ingredient.ProductId = product.First().ProductId;
                            totalPrice += ingredient.Product.Price;
                        }

                        //totalPrice += ingredient.Product.Price;
                    }
                }
                return totalPrice;
            }

            
            
        }
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

    }


}

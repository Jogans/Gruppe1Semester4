using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Remotion.Linq.Parsing.Structure.IntermediateModel;

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
                RecipeQuery recipeQuery = new RecipeQuery
                {
                    SearchRecipe = word,
                    LoadIngredientList = true,
                    LoadRecipeCategory = true,
                    NumberOfRecipes = 1,
                    Stores = stores,
                    ValidToDate = "2050"

                };
                ProductQuery query = new ProductQuery
                {
                    ValidToDate = "2050",
                    NumberOfProducts = 1,
                    Stores = stores
                };
                var listProduct = await query.Execute(db);

                RecipeRepository recipeRepository = new RecipeRepository(db);
                var recipeList = await recipeRepository.Get(recipeQuery);
                ProductRepository productRepository = new ProductRepository(db);



                foreach (var recipe in recipeList)
                {
                    //take all ingredients in the ingredientlist
                    foreach (var ingredient in recipe.IngredientList.Ingredient)
                    {
                        normalPrice += ingredient.Product.Price;
                    }
                }
                return normalPrice;

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
                var recipeList = await recipeRepository.Get(recipequery);
                ProductRepository productRepository = new ProductRepository(db);
                var listProduct = await query.Execute(db);


                foreach (var recipe in recipeList)
                {
                    //take all ingredients in the ingredientlist
                    foreach (var ingredient in recipe.IngredientList.Ingredient)
                    {
                        totalPrice += ingredient.Product.Price;
                    }
                }
                return totalPrice;
            }
        }
        

    }
}

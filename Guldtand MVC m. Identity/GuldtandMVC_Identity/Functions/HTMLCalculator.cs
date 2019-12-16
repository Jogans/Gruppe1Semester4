using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data;
using GuldtandMVC_Identity.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Identity;
using GuldtandMVC_Identity.Data.Queries;
using GuldtandMVC_Identity.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using GuldtandMVC_Identity.Functions;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace GuldtandMVC_Identity.Models
{
    public class HtmlCalculator : IHtmlCalculator
    {
        public async Task<double> NormalPrice(Recipe recipe, string word, string[] stores, Prj4databaseContext context)
        {
            double normalPrice = 0;

            using (var db = context)
            {
                ProductRepository productRepository = new ProductRepository(db);
                //take all ingredients in the ingredientlist
                foreach (var ingredient in recipe.IngredientList.Ingredient)
                {
                    ProductQuery productQuery = new ProductQuery
                    {
                        ValidToDate = "2050",
                        NumberOfProducts = 1,
                        Stores = stores,
                        SearchName = ingredient.Name,
                        LoadRetailChain = true
                    };
                    var listProduct = await productRepository.Get(productQuery);
                    if (listProduct.Any())
                    {
                        foreach (var product in listProduct)
                        {
                            if (product.Name != null)
                            {
                                normalPrice += product.Price;
                            }
                        }
                    }
                    else
                    {
                        normalPrice += ingredient.Product.Price;
                    }
                }
                normalPrice = Math.Round(normalPrice);
                return normalPrice;

            }

        }
        
        public async Task<double> TotalPrice(Recipe recipe, string word, string[] stores, Prj4databaseContext context)
        {
            double totalPrice = 0;

            using (var db = context)
            {
                ProductRepository productRepository = new ProductRepository(db);

                //take all ingredients in the ingredientlist
                foreach (var ingredient in recipe.IngredientList.Ingredient)
                {

                    ProductQuery productQuery = new ProductQuery
                    {
                        NumberOfProducts = 1,
                        Stores = stores,
                        SearchName = ingredient.Name,
                        LoadRetailChain = true
                    };
                    var listProduct = await productRepository.Get(productQuery);

                    if (listProduct.Any())
                    {
                        totalPrice += listProduct.First().Price;
                    }
                    else
                    {
                        totalPrice += ingredient.Product.Price;
                    }
                }
                totalPrice = Math.Round(totalPrice);
                return totalPrice;
            }
        }
        

    }
}

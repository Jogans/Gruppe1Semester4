﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Repositories;

namespace GuldtandMVC_Identity.Data.Queries
{
    public class RecipeQuery : IQuery<Recipe>
    {
        public bool LoadIngredientList { get; set; } = false;
        public bool LoadRecipeCategory { get; set; } = false;
        public string SearchRecipe { get; set; } = "";
        public string SearchIngredient { get; set; } = "";
        public int NumberOfRecipes { get; set; } = 20;
        public string[] Stores { get; set; } = new string[8];

        public async Task<IEnumerable<Recipe>> Execute(prj4databaseContext context)
        {
            var relevantRecipes = await context.Set<Ingredient>()
                .Where(i => i.Name.Contains(SearchIngredient))
                .Select(i => i.IngredientList.RecipeId)
                .ToListAsync();

            switch (LoadIngredientList)
            {
                case true:
                    switch (LoadRecipeCategory)
                    {
                        case true:
                            var recipes1 = await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .Include(r => r.IngredientList.Ingredient)
                                    .ThenInclude(i => i.Product)
                                .Include(r => r.RecipeCategory)
                                .Include(r => r.Directions)
                                .OrderBy(r => r.Price)
                                .Take(NumberOfRecipes)
                                .ToListAsync();
                            IngredientRepository ingredientRepository1 = new IngredientRepository(context);
                            foreach (var recipe in recipes1)
                            {
                                foreach (var ingredient in recipe.IngredientList.Ingredient)
                                {
                                    ProductQuery productQuery = new ProductQuery
                                    {
                                        SearchName = ingredient.Name,
                                        NumberOfProducts = 1,
                                        LoadRetailChain = true,
                                        Stores = Stores
                                    };
                                    var product = await productQuery.Execute(context);
                                    if (product.Any())
                                    {
                                        ingredient.ProductId = product.First().ProductId;
                                        ingredientRepository1.Update(ingredient);
                                    }
                                }
                            }
                            ingredientRepository1.Save();
                            return recipes1;
                        //return await context.Set<Recipe>()
                        //    .Join(context.Ingredient, recipe => recipe.RecipeId, ing => ing.IngredientList.RecipeId,
                        //        (recipe, ing) => new {Recipe = recipe, Ingredient = ing})
                        //    .Where(r => r.Recipe.Name.Contains(SearchRecipe) &&
                        //                r.Ingredient.Name.Contains(SearchIngredient))
                        //    .Include(r => r.Recipe.IngredientList)
                        //    .Take(NumberOfRecipes)
                        //    .ToListAsync();
                        case false:
                            var recipes2 = await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .Include(r => r.IngredientList.Ingredient)
                                .ThenInclude(i => i.Product)
                                .Include(r => r.Directions)
                                .OrderBy(r => r.Price)
                                .Take(NumberOfRecipes)
                                .ToListAsync();
                            IngredientRepository ingredientRepository2 = new IngredientRepository(context);
                            foreach (var recipe in recipes2)
                            {
                                foreach (var ingredient in recipe.IngredientList.Ingredient)
                                {
                                    ProductQuery productQuery = new ProductQuery
                                    {
                                        SearchName = $"{ingredient.Name}",
                                        NumberOfProducts = 1,
                                        LoadRetailChain = true,
                                        Stores = Stores
                                    };
                                    var product = await productQuery.Execute(context);
                                    if (product.Any())
                                    {
                                        ingredient.ProductId = product.First().ProductId;
                                        ingredientRepository2.Update(ingredient);
                                    }
                                }
                            }
                            ingredientRepository2.Save();
                            return recipes2;
                        default:
                            var recipes6 = await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .Include(r => r.IngredientList.Ingredient)
                                .ThenInclude(i => i.Product)
                                .Include(r => r.Directions)
                                .OrderBy(r => r.Price)
                                .Take(NumberOfRecipes)
                                .ToListAsync();
                            IngredientRepository ingredientRepository6 = new IngredientRepository(context);
                            foreach (var recipe in recipes6)
                            {
                                foreach (var ingredient in recipe.IngredientList.Ingredient)
                                {
                                    ProductQuery productQuery = new ProductQuery
                                    {
                                        SearchName = $"{ingredient.Name}",
                                        NumberOfProducts = 1,
                                        LoadRetailChain = true
                                    };
                                    var product = await productQuery.Execute(context);
                                    if (product.Any())
                                    {
                                        ingredient.ProductId = product.First().ProductId;
                                        ingredientRepository6.Update(ingredient);
                                    }
                                }
                            }
                            ingredientRepository6.Save();
                            return recipes6;
                    }
                case false:
                    switch (LoadRecipeCategory)
                    {
                        case true:
                            var recipes3 = await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .Include(r => r.RecipeCategory)
                                .Include(r => r.Directions)
                                .OrderBy(r => r.Price)
                                .Take(NumberOfRecipes)
                                .ToListAsync();
                            return recipes3;
                        case false:
                            var recipes4 = await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .Include(r => r.Directions)
                                .OrderBy(r => r.Price)
                                .Take(NumberOfRecipes)
                                .ToListAsync();
                            return recipes4;
                        default:
                            var recipes7 = await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .Include(r => r.Directions)
                                .OrderBy(r => r.Price)
                                .Take(NumberOfRecipes)
                                .ToListAsync();
                            return recipes7;
                    }
                default:
                    var recipes8 = await context.Set<Recipe>()
                        .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                        .Include(r => r.Directions)
                        .OrderBy(r => r.Price)
                        .Take(NumberOfRecipes)
                        .ToListAsync();
                    return recipes8;
            }
            var recipes5 = await context.Set<Recipe>()
                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                .Include(r => r.Directions)
                .OrderBy(r => r.Price)
                .Take(NumberOfRecipes)
                .ToListAsync();
            return recipes5;
        }

        //public async Task<IEnumerable<Recipe>> Execute<Recipe>(prj4databaseContext context)
        //{
        //    switch (LoadIngredientList)
        //    {
        //        case true:
        //            switch (LoadRecipeCategory)
        //            {
        //                case true:
        //                    return await context.Set<Recipe>()
        //                        .Where(r => r.Name.Contains(SearchRecipe))
        //                        .Include(r => r.IngredientList)
        //                        .Include(r => r.RecipeCategory)
        //                        .ToListAsync();
        //                case false:
        //                    return await context.Set<Recipe>()
        //                        .Where(r => r.Name.Contains(SearchRecipe))
        //                        .Include(r => r.IngredientList)
        //                        .ToListAsync();
        //                default:
        //                    return await context.Set<Recipe>()
        //                        .Where(r => r.Name.Contains(SearchRecipe))
        //                        .ToListAsync();
        //            }
        //            break;
        //        case false:
        //            switch (LoadRecipeCategory)
        //            {
        //                case true:
        //                    return await context.Set<Recipe>()
        //                        .Where(r => r.Name.Contains(SearchRecipe))
        //                        .Include(r => r.RecipeCategory)
        //                        .ToListAsync();
        //                case false:
        //                    return await context.Set<Recipe>()
        //                        .Where(r => r.Name.Contains(SearchRecipe))
        //                        .ToListAsync();
        //                default:
        //                    return await context.Set<Recipe>()
        //                        .Where(r => r.Name.Contains(SearchRecipe))
        //                        .ToListAsync();
        //            }
        //        default:
        //            return await context.Set<Recipe>()
        //                .Where(r => r.Name.Contains(SearchRecipe))
        //                .ToListAsync();
        //    }
        //}
    }
}

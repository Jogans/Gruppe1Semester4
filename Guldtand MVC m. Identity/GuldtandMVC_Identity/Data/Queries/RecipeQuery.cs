using System;
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
                            var recipes = await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .OrderBy(r => r.Price)
                                .Include(r => r.IngredientList.Ingredient)
                                .ThenInclude(i => i.Product)
                                .Include(r => r.RecipeCategory)
                                .Include(r => r.Directions)
                                .Take(NumberOfRecipes)
                                .ToListAsync();
                            IngredientRepository ingredientRepository = new IngredientRepository(context);
                            foreach (var recipe in recipes)
                            {
                                foreach (var ingredient in recipe.IngredientList.Ingredient)
                                {
                                    ProductQuery productQuery = new ProductQuery
                                    {
                                        SearchName = ingredient.Name,
                                        NumberOfRecipes = 1,
                                        LoadRetailChain = true
                                    };
                                    var product = await productQuery.Execute(context);
                                    if (product.Any())
                                    {
                                        ingredient.ProductId = product.First().ProductId;
                                        ingredientRepository.Update(ingredient);
                                    }
                                }
                            ingredientRepository.Save();
                            }
                            return recipes;
                        //return await context.Set<Recipe>()
                        //    .Join(context.Ingredient, recipe => recipe.RecipeId, ing => ing.IngredientList.RecipeId,
                        //        (recipe, ing) => new {Recipe = recipe, Ingredient = ing})
                        //    .Where(r => r.Recipe.Name.Contains(SearchRecipe) &&
                        //                r.Ingredient.Name.Contains(SearchIngredient))
                        //    .Include(r => r.Recipe.IngredientList)
                        //    .Take(NumberOfRecipes)
                        //    .ToListAsync();
                        case false:
                            return await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .OrderBy(r => r.Price)
                                .Include(r => r.IngredientList.Ingredient)
                                .ThenInclude(i => i.Product)
                                .Take(NumberOfRecipes)
                                .ToListAsync();
                        default:
                            return await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .OrderBy(r => r.Price)
                                .Include(r => r.IngredientList.Ingredient)
                                .ThenInclude(i => i.Product)
                                .Take(NumberOfRecipes)
                                .ToListAsync();
                    }
                case false:
                    switch (LoadRecipeCategory)
                    {
                        case true:
                            return await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .OrderBy(r => r.Price)
                                .Include(r => r.RecipeCategory)
                                .Take(NumberOfRecipes)
                                .ToListAsync();
                        case false:
                            return await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .OrderBy(r => r.Price)
                                .Take(NumberOfRecipes)
                                .ToListAsync();
                        default:
                            return await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .OrderBy(r => r.Price)
                                .Take(NumberOfRecipes)
                                .ToListAsync();
                    }
                default:
                    return await context.Set<Recipe>()
                        .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .OrderBy(r => r.Price)
                                .Take(NumberOfRecipes)
                        .ToListAsync();
            }
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

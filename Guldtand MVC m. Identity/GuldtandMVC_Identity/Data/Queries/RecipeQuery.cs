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
        public string[] Stores { get; set; } = new string[8];

        public string ValidToDate { get; set; } = "";

        public async Task<IEnumerable<Recipe>> Execute(Prj4databaseContext context)
        {
            var relevantRecipes = await context.Set<Ingredient>()
                .Where(i => i.Name.Contains(SearchIngredient))
                .Select(i => i.IngredientList.RecipeId)
                .ToListAsync();

            if (LoadIngredientList && LoadRecipeCategory)
            {
                var recipes = await context.Set<Recipe>()
                    .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                    .Include(r => r.IngredientList.Ingredient)
                    .ThenInclude(i => i.Product)
                    .Include(r => r.RecipeCategory)
                    .Include(r => r.Directions)
                    .OrderBy(r => r.SavingsAbsolute)
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
                            NumberOfProducts = 1,
                            LoadRetailChain = true,
                            Stores = Stores,
                            ValidToDate = ValidToDate
                        };
                        var product = await productQuery.Execute(context);
                        if (product.Any())
                        {
                            ingredient.ProductId = product.First().ProductId;
                            ingredientRepository.Update(ingredient);
                        }
                    }
                }
                ingredientRepository.Save();
                return recipes;
            }
            else if (LoadIngredientList && !LoadRecipeCategory)
            {
                var recipes = await context.Set<Recipe>()
                    .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                    .Include(r => r.IngredientList.Ingredient)
                    .ThenInclude(i => i.Product)
                    .Include(r => r.Directions)
                    .OrderBy(r => r.SavingsAbsolute)
                    .Take(NumberOfRecipes)
                    .ToListAsync();
                IngredientRepository ingredientRepository = new IngredientRepository(context);
                foreach (var recipe in recipes)
                {
                    foreach (var ingredient in recipe.IngredientList.Ingredient)
                    {
                        ProductQuery productQuery = new ProductQuery
                        {
                            SearchName = $"{ingredient.Name}",
                            NumberOfProducts = 1,
                            LoadRetailChain = true,
                            Stores = Stores,
                            ValidToDate = ValidToDate
                        };
                        var product = await productQuery.Execute(context);
                        if (product.Any())
                        {
                            ingredient.ProductId = product.First().ProductId;
                            ingredientRepository.Update(ingredient);
                        }
                    }
                }
                ingredientRepository.Save();
                return recipes;
            }
            else if (!LoadIngredientList && LoadRecipeCategory)
            {
                var recipes = await context.Set<Recipe>()
                    .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                    .Include(r => r.RecipeCategory)
                    .Include(r => r.Directions)
                    .OrderBy(r => r.SavingsAbsolute)
                    .Take(NumberOfRecipes)
                    .ToListAsync();
                return recipes;
            }
            else
            {
                var recipes = await context.Set<Recipe>()
                    .Where(r => r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                    .Include(r => r.Directions)
                    .OrderBy(r => r.SavingsAbsolute)
                    .Take(NumberOfRecipes)
                    .ToListAsync();
                return recipes;
            }
        }
    }
}

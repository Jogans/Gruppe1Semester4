using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace tilbud.Queries
{
    public class RecipeQuery
    {
        public bool LoadIngredientList { get; set; } = false;
        public bool LoadSubscriptions { get; set; } = false;
        public string SearchRecipe { get; set; } = "";
        public string SearchIngredient { get; set; } = "";

        public async Task<IEnumerable<Recipes>> Execute(prj4databaseContext context)
        {
            List<int> relevantRecipes = new List<int>();
            foreach (var ingredientList in context.IngredientList)
            {
                if (ingredientList.IngredientName.Contains(SearchIngredient))
                {
                    relevantRecipes.Add(ingredientList.RecipeNavigation.RecipeId);
                }
            }
            switch (LoadIngredientList)
            {
                case true:
                    switch (LoadSubscriptions)
                    {
                        case true:
                            return await context.Set<Recipes>()
                                .Where(r=>r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .Include(r => r.IngredientList)
                                .Include(r => r.Subscriptions)
                                .ToListAsync();
                        case false:
                            return await context.Set<Recipes>()
                                .Where(r=>r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .Where(r=>r.Name.Contains(SearchRecipe))
                                .Include(r => r.IngredientList)
                                .ToListAsync();
                        default:
                            return await context.Set<Recipes>()
                                .Where(r=>r.Name.Contains(SearchRecipe))
                                .ToListAsync();
                    }
                    break;
                case false:
                    switch (LoadSubscriptions)
                    {
                        case true:
                            return await context.Set<Recipes>()
                                .Where(r=>r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .Where(r=>r.Name.Contains(SearchRecipe))
                                .Include(r => r.Subscriptions)
                                .ToListAsync();
                        case false:
                            return await context.Set<Recipes>()
                                .Where(r=>r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .Where(r=>r.Name.Contains(SearchRecipe))
                                .ToListAsync();
                        default:
                            return await context.Set<Recipes>()
                                .Where(r=>r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                                .Where(r=>r.Name.Contains(SearchRecipe))
                                .ToListAsync();
                    }
                    default:
                        return await context.Set<Recipes>()
                                .Where(r=>r.Name.Contains(SearchRecipe) && relevantRecipes.Contains(r.RecipeId))
                            .Where(r=>r.Name.Contains(SearchRecipe))
                                .ToListAsync();
            }
        }
    }
}

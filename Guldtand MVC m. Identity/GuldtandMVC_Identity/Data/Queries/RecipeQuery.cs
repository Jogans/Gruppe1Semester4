using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Data.Queries
{
    public class RecipeQuery
    {
        public bool LoadIngredientList { get; set; } = false;
        public bool LoadRecipeCategory { get; set; } = false;
        public string SearchRecipe { get; set; } = "";

        public async Task<IEnumerable<Recipe>> Execute(prj4databaseContext context)
        {
            switch (LoadIngredientList)
            {
                case true:
                    switch (LoadRecipeCategory)
                    {
                        case true:
                            return await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe))
                                .Include(r => r.IngredientList)
                                .Include(r => r.RecipeCategory)
                                .ToListAsync();
                        case false:
                            return await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe))
                                .Include(r => r.IngredientList)
                                .ToListAsync();
                        default:
                            return await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe))
                                .ToListAsync();
                    }
                    break;
                case false:
                    switch (LoadRecipeCategory)
                    {
                        case true:
                            return await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe))
                                .Include(r => r.RecipeCategory)
                                .ToListAsync();
                        case false:
                            return await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe))
                                .ToListAsync();
                        default:
                            return await context.Set<Recipe>()
                                .Where(r => r.Name.Contains(SearchRecipe))
                                .ToListAsync();
                    }
                default:
                    return await context.Set<Recipe>()
                        .Where(r => r.Name.Contains(SearchRecipe))
                        .ToListAsync();
            }
        }
    }
}

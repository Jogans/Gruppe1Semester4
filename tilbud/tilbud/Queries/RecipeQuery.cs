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

        public async Task<IEnumerable<Recipes>> Execute(prj4databaseContext context)
        {
            switch (LoadIngredientList)
            {
                case true:
                    switch (LoadSubscriptions)
                    {
                        case true:
                            return await context.Set<Recipes>()
                                .Where(r=>r.Name.Contains(SearchRecipe))
                                .Include(r => r.IngredientList)
                                .Include(r => r.Subscriptions)
                                .ToListAsync();
                        case false:
                            return await context.Set<Recipes>()
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
                                .Where(r=>r.Name.Contains(SearchRecipe))
                                .Include(r => r.Subscriptions)
                                .ToListAsync();
                        case false:
                            return await context.Set<Recipes>()
                                .Where(r=>r.Name.Contains(SearchRecipe))
                                .ToListAsync();
                        default:
                            return await context.Set<Recipes>()
                                .Where(r=>r.Name.Contains(SearchRecipe))
                                .ToListAsync();
                    }
                    default:
                        return await context.Set<Recipes>()
                            .Where(r=>r.Name.Contains(SearchRecipe))
                            .ToListAsync();
            }
        }
    }
}

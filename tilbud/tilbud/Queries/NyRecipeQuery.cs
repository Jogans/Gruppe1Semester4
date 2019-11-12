using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace tilbud.Queries
{
    public class NyRecipeQuery
    {
        public bool LoadIngredientList { get; set; } = false;
        public bool LoadSubscriptions { get; set; } = false;

        public async Task<IEnumerable<Recipes>> Execute(prj4databaseContext context)
        {
            switch (LoadIngredientList)
            {
                case true:
                    switch (LoadSubscriptions)
                    {
                        case true:
                            return await context.Set<Recipes>()
                                .Include(r => r.IngredientList)
                                .Include(r => r.Subscriptions)
                                .ToListAsync();
                        case false:
                            return await context.Set<Recipes>()
                                .Include(r => r.IngredientList)
                                .ToListAsync();
                        default:
                            return await context.Set<Recipes>()
                                .ToListAsync();
                    }
                    break;
                case false:
                    switch (LoadSubscriptions)
                    {
                        case true:
                            return await context.Set<Recipes>()
                                .Include(r => r.Subscriptions)
                                .ToListAsync();
                        case false:
                            return await context.Set<Recipes>()
                                .ToListAsync();
                        default:
                            return await context.Set<Recipes>()
                                .ToListAsync();
                    }
                    default:
                        return await context.Set<Recipes>()
                            .ToListAsync();
            }
        }
    }
}

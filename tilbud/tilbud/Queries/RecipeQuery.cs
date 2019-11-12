using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace tilbud.Queries
{
    public class RecipeQuery
    {
        public bool LoadTimeStamp { get; set; } = true;
        public bool LoadName { get; set; } = true;
        public bool LoadCategory { get; set; } = true;
        public bool LoadDirections { get; set; } = true;
        public bool LoadServings { get; set; } = true;
        public bool LoadPrice { get; set; } = true;
        public bool LoadIngredientList { get; set; } = true;
        public bool LoadSubscriptions { get; set; } = true;

        public void PrintStuff(prj4databaseContext context)
        {
            var recipes = context.Recipes
                .Include(r => r.IngredientList)
                .Include(r => r.Subscriptions)
                .ToList();
            foreach (var ting in recipes)
            {
                Console.WriteLine($"{ting.Name} {ting.IngredientList} {ting.Category} {ting.Price} {ting.RecipeId}");
            }
        }

        public async Task<IEnumerable<Recipes>> Execute(prj4databaseContext context)
        {
            switch (LoadTimeStamp)
            {
                case true:
                    switch (LoadName)
                    {
                        case true:
                            switch (LoadCategory)
                            {
                                case true:
                                    switch (LoadDirections)
                                    {
                                        case true:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case false:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                                case false:
                                    switch (LoadDirections)
                                    {
                                        case true:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case false:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Name)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case false:
                            switch (LoadCategory)
                            {
                                case true:
                                    switch (LoadDirections)
                                    {
                                        case true:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case false:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Category)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                                case false:
                                    switch (LoadDirections)
                                    {
                                        case true:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case false:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Timestamp)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
                case false:
                    switch (LoadName)
                    {
                        case true:
                            switch (LoadCategory)
                            {
                                case true:
                                    switch (LoadDirections)
                                    {
                                        case true:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case false:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Category)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                                case false:
                                    switch (LoadDirections)
                                    {
                                        case true:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Directions)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case false:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Name)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case false:
                            switch (LoadCategory)
                            {
                                case true:
                                    switch (LoadDirections)
                                    {
                                        case true:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:

                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Directions)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case false:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:

                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:

                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Category)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                                case false:
                                    switch (LoadDirections)
                                    {
                                        case true:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Directions)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                        case false:
                                            switch (LoadServings)
                                            {
                                                case true:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Servings)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Servings)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                                case false:
                                                    switch (LoadPrice)
                                                    {
                                                        case true:
                                                            switch (LoadIngredientList)
                                                            {
                                                                case true:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.IngredientList)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                                case false:
                                                                    switch (LoadSubscriptions)
                                                                    {
                                                                        case true:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Price)
                                                                                .Include(r => r.Subscriptions)
                                                                                .ToListAsync();
                                                                        case false:
                                                                            return await context.Set<Recipes>()
                                                                                .Include(r => r.Price)
                                                                                .ToListAsync();
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                        case false:
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
                                                                    }
                                                                    break;
                                                            }
                                                            break;
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
                    
            }
            return await context.Set<Recipes>()
                .Include(r => r.Timestamp)
                .Include(r => r.Name)
                .Include(r => r.Category)
                .Include(r => r.Directions)
                .Include(r => r.Servings)
                .Include(r => r.Price)
                .Include(r => r.IngredientList)
                .Include(r => r.Subscriptions)
                .ToListAsync();
        }

    }
}

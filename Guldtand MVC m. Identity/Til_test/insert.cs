using GuldtandMVC_Identity.Data;
using GuldtandMVC_Identity.Data.Queries;
using GuldtandMVC_Identity.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Til_test
{
    public class insert
    {
        private readonly prj4databaseContext _context;
        public insert(prj4databaseContext context)
        {
            _context = context;
        }

        public async Task insertdataAsync()
        {
                Recipe recipe = new Recipe
                {
                    Directions = "bim bam bum",
                    Name = "test1",
                    Price = 75,
                    Servings = 4,
                    SavingsAbsolute = 10
                };
                _context.Recipe.Add(recipe);
                _context.SaveChanges();

                RecipeCategory recipeCategory = new RecipeCategory
                {
                    RecipeId = recipe.RecipeId,
                    CategoryName = "æg"
                };
                _context.RecipeCategory.Add(recipeCategory);
                _context.SaveChanges();

                IngredientList ingList = new IngredientList
                {
                    RecipeId = recipe.RecipeId
                };
                _context.IngredientList.Add(ingList);
                _context.SaveChanges();
                var produkt = await _context.Set<Product>().Where(p => p.Name.Contains("a")).Take(1).ToListAsync();
                var ingredients = new Ingredient[]
                {
                    new Ingredient{Amount = 50, AmountUnit = "g", Name = "ing1", ProductId = produkt[0].ProductId, IngredientListId = ingList.IngredientListId},
                    new Ingredient{Amount = 50, AmountUnit = "g", Name = "ing1", ProductId = produkt[0].ProductId, IngredientListId = ingList.IngredientListId},
                    new Ingredient{Amount = 50, AmountUnit = "g", Name = "ing1", ProductId = produkt[0].ProductId, IngredientListId = ingList.IngredientListId}
                };
                foreach (Ingredient i in ingredients)
                {
                    _context.Ingredient.Add(i);
                }
                _context.SaveChanges();
        }
    }
}

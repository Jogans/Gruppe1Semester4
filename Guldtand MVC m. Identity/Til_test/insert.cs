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
                    Name = "Flæskesteg a la Marcus",
                    Price = 420,
                    Servings = 1,
                    SavingsAbsolute = 69,
                    CookTime = 600,
                    ImgSrc = "https://www.valdemarsro.dk/wp-content/2011/12/flaeskesteg-abrikos-1.jpg"

                };
                _context.Recipe.Add(recipe);
                _context.SaveChanges();

                var directions = new Directions[]
                {
                    new Directions{Description = "Rør ingredienserne sammen", RecipeId = recipe.RecipeId},
                    new Directions{Description = "Spis maden", RecipeId = recipe.RecipeId}
                };

                foreach (var dir in directions)
                {
                    _context.Directions.Add(dir);
                }

                _context.SaveChanges();

                Category category = new Category {CategoryName = "Dansk klassisk"};

                _context.Category.Add(category);
                _context.SaveChanges();

                RecipeCategory recipeCategory = new RecipeCategory
                {
                    RecipeId = recipe.RecipeId,
                    CategoryName = "Dansk klassisk"
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
                    new Ingredient{Amount = 50, AmountUnit = "g", Name = "Tomat", ProductId = _context.Product.Where(p => p.Name.Contains("tomat")).Take(1).ToList()[0].ProductId, IngredientListId = ingList.IngredientListId},
                    new Ingredient{Amount = 1000, AmountUnit = "g", Name = "Feta", ProductId = _context.Product.Where(p => p.Name.Contains("ost")).Take(1).ToList()[0].ProductId, IngredientListId = ingList.IngredientListId},
                    new Ingredient{Amount = 2, AmountUnit = "mL", Name = "Oliven olie", ProductId = _context.Product.Where(p => p.Name.Contains("olie")).Take(1).ToList()[0].ProductId, IngredientListId = ingList.IngredientListId}
                };
                foreach (Ingredient i in ingredients)
                {
                    _context.Ingredient.Add(i);
                }
                _context.SaveChanges();
        }
    }
}

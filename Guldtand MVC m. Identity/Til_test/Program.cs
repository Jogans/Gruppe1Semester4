using GuldtandMVC_Identity.Data;
using GuldtandMVC_Identity.Data.Queries;
using GuldtandMVC_Identity.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Til_test
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {




            using (var db = new prj4databaseContext())
            {
                RecipeQuery query = new RecipeQuery
                {
                    LoadIngredientList = true,
                    SearchIngredient = "feta"
                };
                RecipeRepository repo = new RecipeRepository(db);

                var data = await repo.Get(query);

                foreach (var VARIABLE in data)
                {
                    Console.WriteLine($"{VARIABLE.Name} - {VARIABLE.Price}");
                }
                //Recipe recipe = new Recipe
                //{
                //    Name = "One Pot Pasta med chorizo",
                //    Price = 85,
                //    Servings = 4,
                //    SavingsAbsolute = 30,
                //    CookTime = 25,
                //    ImgSrc = "https://www.valdemarsro.dk/wp-content/2017/03/one-pot-pasta-1.jpg"

                //};
                //db.Recipe.Add(recipe);
                //db.SaveChanges();

                //var directions = new Directions[]
                //{
                //    new Directions{Description = "Skær ting", RecipeId = recipe.RecipeId},
                //    new Directions{Description = "Put det i en gryde", RecipeId = recipe.RecipeId}
                //};

                //foreach (var dir in directions)
                //{
                //    db.Directions.Add(dir);
                //}

                //db.SaveChanges();

                //Category category = new Category { CategoryName = "Dansk klassisk" };
                //if (!db.Category.Contains(category))
                //{
                //    db.Category.Add(category);
                //    db.SaveChanges();
                //}

                ////RecipeCategory recipeCategory = new RecipeCategory
                ////{
                ////    RecipeId = recipe.RecipeId,
                ////    CategoryName = "Pastaret"
                ////};
                ////db.RecipeCategory.Add(recipeCategory);
                ////db.SaveChanges();

                //IngredientList ingList = new IngredientList
                //{
                //    RecipeId = recipe.RecipeId
                //};
                //db.IngredientList.Add(ingList);
                //db.SaveChanges();
                //var produkt = await db.Set<Product>().Where(p => p.Name.Contains("a")).Take(1).ToListAsync();
                //var ingredients = new Ingredient[]
                //{
                //    new Ingredient{Amount = 400, AmountUnit = "g", Name = "Spaghetti", ProductId = db.Product.Where(p => p.Name.Contains("pasta")).Take(1).ToList()[0].ProductId, IngredientListId = ingList.IngredientListId},
                //    new Ingredient{Amount = 1, AmountUnit = "dåse", Name = "Hakkede tomater", ProductId = db.Product.Where(p => p.Name.Contains("tomat")).Take(1).ToList()[0].ProductId, IngredientListId = ingList.IngredientListId},
                //    new Ingredient{Amount = 1, AmountUnit = " ", Name = "Løg", ProductId = db.Product.Where(p => p.Name.Contains("løg")).Take(1).ToList()[0].ProductId, IngredientListId = ingList.IngredientListId}
                //};
                //foreach (Ingredient i in ingredients)
                //{
                //    db.Ingredient.Add(i);
                //}
                //db.SaveChanges();
            }























            //using (var context = new prj4databaseContext())
            //{
            //    insert insert = new insert(context);
            //    await insert.insertdataAsync();
            //    RecipeRepository repo = new RecipeRepository(context);
            //    RecipeQuery query = new RecipeQuery
            //    {
            //        LoadIngredientList = true,
            //        LoadRecipeCategory = true,
            //        SearchRecipe = ""
            //    };
            //    var opskrifter = await repo.GetRecipes(query);

            //    foreach (var opskrift in opskrifter.Where(o => o.Name.Contains("marcus")))
            //    {
            //        System.Console.WriteLine($"{opskrift.Name}");
            //        Console.WriteLine($"{opskrift.Price}");
            //    }
            //}
        }
    }
}

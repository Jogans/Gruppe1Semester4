using GuldtandMVC_Identity.Data;
using GuldtandMVC_Identity.Data.Queries;
using GuldtandMVC_Identity.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Til_test
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {




            using (var db = new prj4databaseContext())
            {
                var result = from v in db.Recipe where v.Name.Contains("marcus") select v;

                foreach (var recipe in result)
                {
                    foreach (var ingredient in db.Ingredient.Where(i => i.IngredientList.RecipeId == recipe.RecipeId))
                    {

                        foreach (var product in db.Product.Where(p => p.ProductId == ingredient.ProductId))
                        {
                            Console.WriteLine($"{product.Price}");
                        }


                    }
                }
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

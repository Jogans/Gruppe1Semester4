using GuldtandMVC_Identity.Data;
using GuldtandMVC_Identity.Data.Queries;
using GuldtandMVC_Identity.Data.Repositories;
using System;
using System.Collections.Generic;

namespace Til_test
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            using (var context = new prj4databaseContext())
            {
                insert insert = new insert(context);
                await insert.insertdataAsync();
                RecipeRepository repo = new RecipeRepository(context);
                RecipeQuery query = new RecipeQuery
                {
                    LoadIngredientList = true,
                    LoadRecipeCategory = true,
                    SearchRecipe = ""
                };
                var opskrifter = await repo.GetRecipes(query);

                foreach (var opskrift in opskrifter)
                {
                    System.Console.WriteLine($"{opskrift.Name}");
                    Console.WriteLine($"{opskrift.Price}");
                }
            }
        }
    }
}

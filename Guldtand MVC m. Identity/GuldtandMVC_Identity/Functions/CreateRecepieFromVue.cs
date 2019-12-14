using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data.Queries;
using GuldtandMVC_Identity.Data.Repositories;
using GuldtandMVC_Identity.Functions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GuldtandMVC_Identity.Models
{
    public class CreateRecipeFromVue : ICreateRecepieFromVue
    {

        public string HtmlToRecipe(string name, int prepareTime, string description, string ingridientName, string ingridientAmount, string ingridientUnit, string imgUrl)
        {

            string initString = "" +
                                "<html>";

            string style = "<head>" +
                           "<style>" +

                           ".img1{" +
                           "display: block;" +
                           "position: absolute;" +
                           "width: 700px;" +
                           "height: 400px;}" +

                           "</style>" +
                           "</head> ";

            string endString = "</html>";

            string bodystring = "";

            bodystring += "<p>" +
                          "Name: " + name +
                          "<br/>" +
                          " Forberedelses tid: " + prepareTime +
                          "<br/>" +
                          " Fremgangsmåde: " + "<br/>";

            string[] descriptionData = description.Split(';', StringSplitOptions.RemoveEmptyEntries);
            int counter = 1;
            foreach (var index in descriptionData)
            {
                if (index != "null")
                {
                    bodystring += counter++ + ". " + index + "<br/>";
                }
            }

            bodystring += " Ingridiens liste: " + "<br/>";

            string[] nameSplit = ingridientName.Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] amountSplit = ingridientAmount.Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] unitSplit = ingridientUnit.Split(';', StringSplitOptions.RemoveEmptyEntries);
            int sizeIngridient = nameSplit.Length;

            for (int i = 0; i < sizeIngridient; i++)
            {
                bodystring += nameSplit[i] + " " + amountSplit[i] + " " + unitSplit[i] + "<br/>";
            }

            bodystring += "<br/>" +
                          "<img class='img1' src = '" + imgUrl + "' />" +
                "</p>";

            return initString + style + bodystring + endString; ;
        }


        public async Task<string> CreateRecipeToDatabase(string name, int prepareTime, string description, string ingridientName, string ingridientAmount, string ingridientUnit, string imgUrl)
        {
            using (var db = new Prj4databaseContext())
            {
                RecipeQuery recipeQuery = new RecipeQuery
                {
                    SearchRecipe = name
                };
                var queryResult = await recipeQuery.Execute(db);
                if (queryResult.Any())
                {
                    return "Opskrift findes allerede";
                }
                Recipe recipe = new Recipe
                {
                    Name = name,
                    CookTime = prepareTime,
                    ImgSrc = imgUrl,
                    Servings = 4
                };

                RecipeRepository recipeRepository = new RecipeRepository(db);
                recipeRepository.Insert(recipe);
                recipeRepository.Save();
                recipeRepository.Dispose();

                string[] descriptionData = description.Split(';', StringSplitOptions.RemoveEmptyEntries);
                int sizeDescription = descriptionData.Length;
                var directions = new Directions[sizeDescription];
                for (int i = 0; i < sizeDescription; i++)
                {
                    directions[i] = new Directions {Description = descriptionData[i], RecipeId = recipe.RecipeId};
                }

                DirectionsRepository directionsRepository = new DirectionsRepository(db);
                foreach (var direc in directions)
                {
                    directionsRepository.Insert(direc);
                }
                directionsRepository.Save();
                directionsRepository.Dispose();
                var ingredientLists = new IngredientList
                {
                    RecipeId = recipe.RecipeId,
                };
                IngredientListRepository ingredientListRepository = new IngredientListRepository(db);
                ingredientListRepository.Insert(ingredientLists);
                ingredientListRepository.Save();
                ingredientListRepository.Dispose();
                string[] nameSplit = ingridientName.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string[] amountSplit = ingridientAmount.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string[] unitSplit = ingridientUnit.Split(';', StringSplitOptions.RemoveEmptyEntries);
                int sizeIngridient = nameSplit.Length;
                var ingridients = new Ingredient[sizeIngridient];
                var produkt = await db.Set<Product>().Where(p => p.Name.Contains("a")).Take(1).ToListAsync();


                for (int i = 0; i < sizeIngridient; i++)
                {
                    double.TryParse(amountSplit[i], out var amountDouble);
                    ingridients[i] = new Ingredient
                    {
                        Name = nameSplit[i],
                        Amount = amountDouble,
                        AmountUnit = unitSplit[i],
                        ProductId = produkt[0].ProductId,
                        IngredientListId = ingredientLists.IngredientListId
                    };
                }
                IngredientRepository ingredientRepository = new IngredientRepository(db);

                foreach (var ingridient in ingridients)
                {
                    ingredientRepository.Insert(ingridient);
                }
                ingredientRepository.Save();
                ingredientRepository.Dispose();

                return HtmlToRecipe(name, prepareTime, description, ingridientName, ingridientAmount, ingridientUnit, imgUrl);
            }
        }
    }
}

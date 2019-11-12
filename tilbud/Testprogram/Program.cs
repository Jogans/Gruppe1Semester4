using System;
using System.Collections.Generic;
using tilbud;
using tilbud.Queries;
using Transfer.Models;

namespace Testprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            prj4databaseContext context = new prj4databaseContext();
            NyRecipeQuery test = new NyRecipeQuery
            {
                LoadIngredientList = true,
                LoadSubscriptions = true
            };
            var udskrift = test.Execute(context);

            //foreach (var VARIABLE in udskrift)
            //{
            //    Console.WriteLine($"{VARIABLE}");
            //}
            //Console.WriteLine("Hello World!");

            //prj4databaseContext context = new prj4databaseContext();
            //VareRepository objekt = new VareRepository(context);

            //Vare var1 = new Vare();
            ////var1.VareId = 50000;
            //var1.Navn = "Testvare";
            //var1.Pris = 2000.0;
            //var1.Butik = "Netto";
            //var1.ValidFra = "";
            //var1.ValidTil = "";
            //var1.Volumenpris = 100;
            //var1.Volumen = 200;
            //var1.Imgsrc = "";

            //objekt.InsertVare(var1);
            //objekt.Save();

            /*
            prj4databaseContext context = new prj4databaseContext();
            RecipesRepository repo = new RecipesRepository(context);
            IngredientList liste = new IngredientList();
            Vare v1 = new Vare();
            v1.Navn = "Kødboller";
            v1.Pris = 45;
            v1.Butik = "Rema2000";
            v1.ValidFra = "";
            v1.ValidTil = "";
            v1.Volumenpris = 45;
            v1.Volumen = 1000;
            v1.Imgsrc = "";

            Vare v2 = new Vare();
            v1.Navn = "Fiskefillet";
            v1.Pris = 21;
            v1.Butik = "Rema23000";
            v1.ValidFra = "";
            v1.ValidTil = "";
            v1.Volumenpris = 30;
            v1.Volumen = 450;
            v1.Imgsrc = "";
            liste.IngredientId = 2000;

            Recipes recipe = new Recipes();

            recipe.Category = "Vegetar";
            recipe.Directions = "1. Put ting i en skål. 2. Rør dem sammen. 3. Put det i en spand. 4. Spis med glæde!";
            recipe.IngredientList = new List<IngredientList>();
            recipe.Name = "VegetarMedKød";
            recipe.Price = 45;
            recipe.SavingsAbsolute = 20;
            recipe.SavingsPercent = 10;
            recipe.Servings = 2;
            recipe.Subscriptions = new List<Subscriptions>();
            recipe.Timestamp = DateTime.Now;

            repo.InsertRecipe(recipe);
            repo.Save();
            */

        }
    }
}

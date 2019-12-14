using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuldtandMVC_Identity;
using GuldtandMVC_Identity.Data;
using GuldtandMVC_Identity.Data.Queries;
using GuldtandMVC_Identity.Data.Repositories;
using NUnit.Framework;

namespace Guldtand_UnitTests
{
    class RecipeQueryUnitTest
    {
        private RecipeQuery _uut;
        private Prj4databaseContext _context;
        [SetUp]
        public void SetUp()
        {
            _context = new Prj4databaseContext();
            _uut = new RecipeQuery {LoadIngredientList = true};
        }

        [Test]
        public async Task ExecuteQuery_ValidDateSet20501201_OnlyProductsFromDateReturnedForRecipe()
        {
            _uut.ValidToDate = "2050";
            _uut.SearchRecipe = "Hjemmelavet lasagne";
            var recipesList = await _uut.Execute(_context);
            foreach (var recipe in recipesList)
            {
                foreach (var ingredient in recipe.IngredientList.Ingredient)
                {
                    Assert.That(ingredient.Product.ValidTo.Year, Is.EqualTo(2050));
                }
            }
        }

        [Test]
        public async Task ExecuteQuery_SearchForSpeceficName_OnlyOneReturned()
        {
            _uut.SearchRecipe = "Hjemmelavet lasagne";
            var recipesList = await _uut.Execute(_context);
            foreach (var recipe in recipesList)
            {
                Assert.That(recipe.Name, Is.EqualTo("Hjemmelavet lasagne"));
            }
            Assert.That(recipesList.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task ExecuteQuery_IngredientListIncluded()
        {
            _uut.LoadIngredientList = true;
            var recipesList = await _uut.Execute(_context);
            foreach (var recipe in recipesList)
            {
                Assert.That(recipe.IngredientList, Is.Not.EqualTo(null));
            }
        }

        [Test]
        public async Task ExecuteQuery_ReturnRightNumberOfRecipes()
        {
            _uut.NumberOfRecipes = 4;
            var recipesList = await _uut.Execute(_context);
            Assert.That(recipesList.Count(), Is.EqualTo(4));
        }

        [Test]
        public async Task ExecuteQuery_SearchForIngredient_ReturnRecipesWithThatIngredient()
        {
            _uut.SearchIngredient = "Løg";
            var recipesList = await _uut.Execute(_context);

            foreach (var recipe in recipesList)
            {
                bool result = false;
                foreach (var ingredient in recipe.IngredientList.Ingredient)
                {
                    if (ingredient.Name == "Løg")
                    {
                        result = true;
                    }
                }
                Assert.That(result, Is.EqualTo(true));
            }
        }
    }
}

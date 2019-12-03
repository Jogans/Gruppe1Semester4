using GuldtandMVC_Identity.Data.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data;
using GuldtandMVC_Identity.Data.Queries;
using NUnit.Framework;
using Til_test;

namespace Guldtand_UnitTests
{
    public class RecipeRepository_Unit_Test
    {
        private RecipeRepository _uut;
        private prj4databaseContext _context;
        [SetUp]
        public void SetUp()
        {
            _context = new prj4databaseContext();
            _uut = new RecipeRepository(_context);
        }

        [Test]
        public void TestInsert()
        {
            Recipe recipe = new Recipe
            {
                Name = "Test af insert",
                CookTime = 25,
                ImgSrc = "https://tinyurl.com/usevcle"
            };
            _uut.InsertRecipe(recipe);
            _uut.Save();

            Assert.That(_context.Recipe.Contains(recipe), Is.True);

            _uut.DeleteRecipe(recipe.RecipeId);
            _uut.Save();
        }

        [Test]
        public void TestDelete()
        {
            Recipe recipe = new Recipe
            {
                Name = "Test af insert",
                CookTime = 25,
                ImgSrc = "https://tinyurl.com/usevcle"
            };
            _uut.InsertRecipe(recipe);
            _uut.Save();

            _uut.DeleteRecipe(recipe.RecipeId);
            _uut.Save();
            Assert.That(_context.Recipe.Contains(recipe), Is.False);

        }

        [Test]
        public async Task TestRecipeQuery()
        {
            RecipeQuery testQuery = new RecipeQuery
            {
                LoadIngredientList = true,
                LoadRecipeCategory = true,
                NumberOfRecipes = 1,
                SearchRecipe = "marcus"
            };
            InsertRecipeDirectionsCategoryIngredients insert = new InsertRecipeDirectionsCategoryIngredients(_context);
            await insert.insertdataAsync();

            var data = await _uut.GetRecipes(testQuery);

            Assert.That(data.Count() == 1);
            foreach (var VARIABLE in data)
            {
                _uut.DeleteRecipe(VARIABLE.RecipeId);
            }
        }

        [Test]
        public async Task TestRecipeQuery2()
        {
            RecipeQuery testQuery = new RecipeQuery
            {
                LoadIngredientList = true,
                LoadRecipeCategory = true,
                NumberOfRecipes = 3,
                SearchRecipe = "marcus"
            };
            InsertRecipeDirectionsCategoryIngredients insert = new InsertRecipeDirectionsCategoryIngredients(_context);
            await insert.insertdataAsync();

            var data = await _uut.GetRecipes(testQuery);

            Assert.That(data.Count() == 3);
            foreach (var VARIABLE in data)
            {
                _uut.DeleteRecipe(VARIABLE.RecipeId);
            }
        }

        [Test]
        //public async Task TestRecipeQuery3()
        //{
        //    RecipeQuery testQuery = new RecipeQuery
        //    {
        //        LoadIngredientList = true,
        //        LoadRecipeCategory = true,
        //        NumberOfRecipes = 1,
        //        SearchRecipe = "marcus"
        //    };
        //    InsertRecipeDirectionsCategoryIngredients insert = new InsertRecipeDirectionsCategoryIngredients(_context);
        //    await insert.insertdataAsync();

        //    var data = await _uut.GetRecipes(testQuery);

        //    Assert.That(data.Count() == 3);
        //    var data2 = data.ToList();
        //    Assert.That(data2[0].IngredientList.Ingredient.Contains());
        //    foreach (var VARIABLE in data)
        //    {
        //        _uut.DeleteRecipe(VARIABLE.RecipeId);
        //    }
        //}
    }
}

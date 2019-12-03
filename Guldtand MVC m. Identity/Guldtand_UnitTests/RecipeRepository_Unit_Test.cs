using GuldtandMVC_Identity.Data.Repositories;
using System;
using System.Linq;
using GuldtandMVC_Identity.Data;
using NUnit.Framework;

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
            _uut.Insert(recipe);
            _uut.Save();

            Assert.That(_context.Recipe.Contains(recipe), Is.True);

            _uut.Delete(recipe.RecipeId);
            _uut.Save();
        }
    }
}

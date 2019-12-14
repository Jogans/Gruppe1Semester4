using GuldtandMVC_Identity.Data.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity;
using GuldtandMVC_Identity.Data;
using GuldtandMVC_Identity.Data.Queries;
using NUnit.Framework;

namespace Guldtand_UnitTests
{
    public class RecipeRepositoryUnitTest
    {
        private RecipeRepository _uut;
        private Prj4databaseContext _context;
        [SetUp]
        public void SetUp()
        {
            _context = new Prj4databaseContext();
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

        [Test]
        public void TestDelete()
        {
            Recipe recipe = new Recipe
            {
                Name = "Test af insert",
                CookTime = 25,
                ImgSrc = "https://tinyurl.com/usevcle"
            };
            _uut.Insert(recipe);
            _uut.Save();

            _uut.Delete(recipe.RecipeId);
            _uut.Save();
            Assert.That(_context.Recipe.Contains(recipe), Is.False);

        }
    }
}

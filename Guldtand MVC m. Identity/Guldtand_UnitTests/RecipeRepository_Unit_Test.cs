using GuldtandMVC_Identity.Data.Repositories;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity;
using GuldtandMVC_Identity.Data;
using GuldtandMVC_Identity.Data.Queries;
using Microsoft.EntityFrameworkCore;
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

            string ConnectionString = "Data Source=prj4-server.database.windows.net;Initial Catalog=prj4-database;User ID=maloudt;Password=Mldt1160";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            var options = new DbContextOptionsBuilder<Prj4databaseContext>()
                .UseSqlServer(conn).Options;

            _context = new Prj4databaseContext(options);
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuldtandMVC_Identity;
using GuldtandMVC_Identity.Data.Queries;
using GuldtandMVC_Identity.Data.Repositories;
using GuldtandMVC_Identity.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using NSubstitute;
using NSubstitute.Extensions;


namespace Guldtand_UnitTests
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        public IQuery<Product> ProductQuery;
        public IQuery<Recipe> RecipeQuesry;
        public Recipe Recipe;
        public Product Product;
        private HtmlCalculator _uut;
        public Prj4databaseContext _context;
        
        [SetUp]
        public void Setup()
        {
            ProductQuery = Substitute.For<IQuery<Product>>();
            RecipeQuesry = Substitute.For<IQuery<Recipe>>();
            Product = Substitute.For<Product>();
            _uut = new HtmlCalculator();
            string ConnectionString = "Data Source=prj4-server.database.windows.net;Initial Catalog=prj4-database;User ID=maloudt;Password=Mldt1160";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            var options = new DbContextOptionsBuilder<Prj4databaseContext>()
                .UseSqlServer(conn).Options;

            _context = new Prj4databaseContext(options);
        }


        [TestCase("Hjemmelavet Lasagne")]
        [TestCase("Pandekager")]
        [TestCase("Pølsehorn")]
        [TestCase("Brændende Kærlighed")]
        [TestCase("Spaghetti med kødsovs")]
        [TestCase("Kylling i karry")]
        [TestCase("Hjemmelavet lasagne")]
        public async Task TestTotalPriceEqualToOrSmallerThenNormalPrice(string name)
        {
            RecipeQuery recipeQuery = new RecipeQuery
            {
                SearchRecipe = name,
                LoadIngredientList = true,
                NumberOfRecipes = 1,
            };

            var recipe = await recipeQuery.Execute(_context);

            string[] empty = new string[8];
            double resultTotal = await _uut.TotalPrice(recipe.First(), name, empty, _context);
            double resultNormal = await _uut.NormalPrice(recipe.First(), name, empty, _context);
            Assert.That(true, Is.EqualTo(resultTotal <= resultNormal));
        }

        [TestCase("Hjemmelavet Lasagne")]
        [TestCase("Pandekager")]
        [TestCase("Pølsehorn")]
        [TestCase("Brændende Kærlighed")]
        [TestCase("Spaghetti med kødsovs")]
        [TestCase("Kylling i karry")]
        [TestCase("Hjemmelavet lasagne")]
        public async Task TestNormalPrice(string name)
        {
            RecipeQuery recipeQuery = new RecipeQuery
            {
                SearchRecipe = name,
                LoadIngredientList = true,
                NumberOfRecipes = 1,
            };

            var recipe = await recipeQuery.Execute(_context);

            string[] empty = new string[8];
            double resultTotal = await _uut.TotalPrice(recipe.First(), name, empty, _context);
            double resultNormal = await _uut.NormalPrice(recipe.First(), name, empty, _context);
            Assert.That(true, Is.EqualTo(resultNormal >= resultTotal));
        }
    }
}
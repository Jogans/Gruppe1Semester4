using System.Threading.Tasks;
using GuldtandMVC_Identity;
using GuldtandMVC_Identity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using NUnit.Framework;
using System;
using System.Data.SqlClient;

namespace Guldtand_UnitTests
{
    [TestFixture]
    public class RecipeUnitTest
    {
        private AddHtmlToRecipe _uut;
        private Prj4databaseContext _context;

        [SetUp]
        public void Setup()
        {
            _uut = new AddHtmlToRecipe();
            string ConnectionString = "Data Source=prj4-server.database.windows.net;Initial Catalog=prj4-database;User ID=maloudt;Password=Mldt1160";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            var options = new DbContextOptionsBuilder<Prj4databaseContext>()
                .UseSqlServer(conn).Options;

            _context = new Prj4databaseContext(options);
        }

        [TestCase("Lasagne", "<html>")] //HTML start tag
        [TestCase("Lasagne", "</html>")] //HTML end tag
        [TestCase("Lasagne", "img")] //image included
        [TestCase("Lasagne", "Lasagne")] //Recipe name included
        [TestCase("Brændende Kærlighed", "Brændende Kærlighed")] //Recipe name included
        [TestCase("Pandekager", "Pandekager")] //Recipe name included
        public async Task TestForReturningHtmlCodeFromFunctionShowFullRecipe(string searchWord, string htmlExpected)
        {
            var resultString = await _uut.ShowRecipeFullView(searchWord, 4, _context);

            StringAssert.Contains(htmlExpected, resultString);
        }

        [TestCase("<html>")] //HTML start tag
        [TestCase("</html>")] //HTML end tag
        [TestCase("img")] //image included
        [TestCase("Hjemmelavet lasagne")] //Recipe name included
        [TestCase("Brændende Kærlighed")] //Recipe name included
        [TestCase( "Pandekager")] //Recipe name included
        [TestCase("<style>")] //Css included
        public async Task TestForReturningHtmlCodeFromFunctionShowSmallRecipeAllStoresAllRecipes(string htmlExpected)
        {
            string allStores = "";

            var resultString = await _uut.ShowRecipeSmallViewAsync(allStores, 20, _context);

            StringAssert.Contains(htmlExpected, resultString);
        }


    }
}
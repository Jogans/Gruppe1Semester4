using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuldtandMVC_Identity;
using GuldtandMVC_Identity.Data.Queries;
using GuldtandMVC_Identity.Data.Repositories;
using GuldtandMVC_Identity.Models;
using NUnit.Framework;
using sun.security.pkcs10;
using NSubstitute;


namespace Guldtand_UnitTests
{
    [TestFixture]
    public class RecipeUnitTest
    {
        private AddHTMLToRecipe _uut;
        private prj4databaseContext _context;
        public IQuery<Product> _ProductQuery;
        public IQuery<Recipe> _RecipeQuesry;
        public Product _Product;

        [SetUp]
        public void Setup() 
        {
            _ProductQuery = Substitute.For<IQuery<Product>>();
            _RecipeQuesry = Substitute.For<IQuery<Recipe>>();
            _Product = Substitute.For<Product>();
            _uut = new AddHTMLToRecipe();
        }

        [TestCase("Lasagne", "<html>")] //HTML start tag
        [TestCase("Lasagne", "</html>")] //HTML end tag
        [TestCase("Lasagne", "img")] //image included
        [TestCase("Lasagne", "Lasagne")] //Recipe name included
        [TestCase("Brændende Kærlighed", "Brændende Kærlighed")] //Recipe name included
        [TestCase("Pandekager", "Pandekager")] //Recipe name included
        public async Task TestForReturningHTMLCodeFromFunctionShowFullRecipe(string searchWord, string htmlExpected)
        {
            Task<string> resultString = _uut.ShowRecipeFullView(searchWord, 4);

            StringAssert.Contains(htmlExpected, resultString.Result);
        }

        [TestCase("<html>")] //HTML start tag
        [TestCase("</html>")] //HTML end tag
        [TestCase("img")] //image included
        [TestCase("Hjemmelavet lasagne")] //Recipe name included
        [TestCase("Brændende Kærlighed")] //Recipe name included
        [TestCase( "Pandekager")] //Recipe name included
        [TestCase("<style>")] //Css included
        public async Task TestForReturningHTMLCodeFromFunctionShowSmallRecipeAllStoresAllRecipes(string htmlExpected)
        {
            string allStores = "";

            Task<string> resultString = _uut.ShowRecipeSmallViewAsync(allStores, 20);

            StringAssert.Contains(htmlExpected, resultString.Result);
        }


    }
}
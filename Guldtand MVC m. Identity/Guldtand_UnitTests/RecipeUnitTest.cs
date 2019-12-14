using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Models;
using NUnit.Framework;

namespace Guldtand_UnitTests
{
    [TestFixture]
    public class RecipeUnitTest
    {
        private AddHtmlToRecipe _uut;

        [SetUp]
        public void Setup() 
        {
            _uut = new AddHtmlToRecipe();
        }

        [TestCase("Lasagne", "<html>")] //HTML start tag
        [TestCase("Lasagne", "</html>")] //HTML end tag
        [TestCase("Lasagne", "img")] //image included
        [TestCase("Lasagne", "Lasagne")] //Recipe name included
        [TestCase("Brændende Kærlighed", "Brændende Kærlighed")] //Recipe name included
        [TestCase("Pandekager", "Pandekager")] //Recipe name included
        public async Task TestForReturningHtmlCodeFromFunctionShowFullRecipe(string searchWord, string htmlExpected)
        {
            var resultString = await _uut.ShowRecipeFullView(searchWord, 4);

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

            var resultString = await _uut.ShowRecipeSmallViewAsync(allStores, 20);

            StringAssert.Contains(htmlExpected, resultString);
        }


    }
}
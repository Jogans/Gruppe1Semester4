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
    public class CalculatorUnitTest
    {
        public IQuery<Product> _ProductQuery;
        public IQuery<Recipe> _RecipeQuesry;
        public Product _Product;
        private HTMLCalculator _uut;
        
        [SetUp]
        public void Setup()
        {
            _ProductQuery = Substitute.For<IQuery<Product>>();
            _RecipeQuesry = Substitute.For<IQuery<Recipe>>();
            _Product = Substitute.For<Product>();
            _uut = new HTMLCalculator();
        }


        [TestCase("Lasange")]
        [TestCase("Pandekager")]
        [TestCase("Pølsehorn")]
        [TestCase("Brændende Kærlighed")]
        [TestCase("Spaghetti med kødsovs")]
        [TestCase("Kylling i karry")]
        [TestCase("Hjemmelavet lasagne")]
        public async  Task TestTotalPriceEqualToOrSmallerThenNormalPrice(string name)
        {
            string[] empty = new string[8];
            double resultTotal = await _uut.TotalPrice(name, empty);
            double resultNormal = await _uut.NormalPrice(name, empty);
            Assert.That(true, Is.EqualTo(resultTotal <= resultNormal));
        }

        [TestCase("Lasange")]
        [TestCase("Pandekager")]
        [TestCase("Pølsehorn")]
        [TestCase("Brændende Kærlighed")]
        [TestCase("Spaghetti med kødsovs")]
        [TestCase("Kylling i karry")]
        [TestCase("Hjemmelavet lasagne")]
        public async Task TestNormalPrice(string name)
        {
            string[] empty = new string[8];
            double resultTotal = await _uut.TotalPrice(name, empty);
            double resultNormal = await _uut.NormalPrice(name, empty);
            Assert.That(true, Is.EqualTo(resultNormal >= resultTotal));
        }
    }
}
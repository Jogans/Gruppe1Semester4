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


namespace Guldtand_UnitTests
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private HTMLCalculator _uut;
        
        [SetUp]
        public void Setup()
        {
            
            _uut = new HTMLCalculator();
        }

        [Test]
        public async  Task CalculatorCalculating()
        {
            //forventet udregning
            //normalpris kun tages med hvis den er validto over 2049. didnotrecieve kald.
            /*var products = 20;

            foreach (var product in products)
            {
                Assert.That(products.CompareTo(20) == 20);
            }
            */
        }
        
        [Test]
        public async Task CalculatorReturningNormalpriceIfdateExceed2049()
        {
            //forventet udregning
            //normalpris kun tages med hvis den er validto over 2049. didnotrecieve kald.
            //var products = await _uut.normalPrice();
            //_uut.totalPrice()
           // int productLifeTime = Int32.Parse(_product.ValidToDate);
            //foreach (var product in products)
            //{
              //  Assert.That(product.ValidTo.Year == 2050);
           // }

        }

        [Test]
        public async Task CalculatorGetsSearchWord()
        {
            //forventet udregning
            //normalpris kun tages med hvis den er validto over 2049. didnotrecieve kald.
            var word = "ovnbagt pasta";
            //int productLifeTime = Int32.Parse(_query.ValidToDate);
            Assert.That(word.Contains("pasta"));
            

        }
        [Test]
        public async Task CalculatorDividebyZero()
        {
            //forventet udregning
            //normalpris kun tages med hvis den er validto over 2049. didnotrecieve kald.
            var uut = new HTMLCalculator();
            Product p1 = new Product();
            Product p2 = new Product();

            //uut.normalPrice(0);
            p1.Price = 10;
            p2.Price = 12;
            var products = (p1,p2);
            //normalPrice() += p1.Price;


            //Assert.That(p1).AreEqual<int>(25, result);
            Assert.That(products,Is.EqualTo(22));

        }
    }
}
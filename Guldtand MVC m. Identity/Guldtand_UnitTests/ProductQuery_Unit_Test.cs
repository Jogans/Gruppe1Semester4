using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuldtandMVC_Identity;
using GuldtandMVC_Identity.Data;
using GuldtandMVC_Identity.Data.Queries;
using GuldtandMVC_Identity.Data.Repositories;
using NUnit.Framework;

namespace Guldtand_UnitTests
{
    class ProductQuery_Unit_Test
    {
        private ProductQuery _uut;
        private prj4databaseContext _context;
        [SetUp]
        public void SetUp()
        {
            _context = new prj4databaseContext();
            _uut = new ProductQuery();
        }

        [Test]
        public async Task ExecuteQuery_ValidDateSet20501201_OnlyProductsFromDateReturned()
        {
            _uut.ValidToDate = "2050";
            var products = await _uut.Execute(_context);
            foreach (var product in products)
            {
                Assert.That(product.ValidTo.Year == 2050);
            }
        }

        [Test]
        public async Task ExecuteQuery_ValidDateSet20191204_OnlyProductsFromDateReturned()
        {
            _uut.ValidToDate = "2019-12-04";
            var products = await _uut.Execute(_context);
            foreach (var product in products)
            {
                Assert.That(product.ValidTo.Year == 2050);
            }
        }
    }
}

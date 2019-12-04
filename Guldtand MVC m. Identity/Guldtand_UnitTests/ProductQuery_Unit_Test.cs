using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public async Task ÉxecuteQuery_ValidDateSet20501201_OnlyProdutsFromDateReturned()
        {
            _uut.ValidToDate = "2050-12-01";
            var products = await _uut.Execute(_context);
            foreach (var product in products)
            {
                Assert.That(product.ValidTo.Year == 2050
                            && product.ValidTo.Month == 12
                            && product.ValidTo.Day == 01);
            }
        }

        [Test]
        public async Task ÉxecuteQuery_ValidDateSet20191204_OnlyProdutsFromDateReturned()
        {
            _uut.ValidToDate = "2019-12-04";
            var products = await _uut.Execute(_context);
            foreach (var product in products)
            {
                Assert.That(product.ValidTo.Year == 2050
                            && product.ValidTo.Month == 12
                            && product.ValidTo.Day == 01);
            }
        }
    }
}

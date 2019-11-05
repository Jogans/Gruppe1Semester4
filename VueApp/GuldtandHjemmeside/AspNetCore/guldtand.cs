using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Controllers;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore
{
    public class guldtand
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public DateTime DateTime { get; set; }
    }
}

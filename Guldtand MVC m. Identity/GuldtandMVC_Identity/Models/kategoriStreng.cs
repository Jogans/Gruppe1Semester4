using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuldtandMVC_Identity.Data;

namespace GuldtandMVC_Identity.Models
{
    public class KategoriStreng
    {
        public KategoriStreng()
        {
            varer = new List<Product>();
        }
        public string kategori { get; set; }
        public List<string> kategories { get; set; }
        public List<Product> varer { get; set; }
    }
}

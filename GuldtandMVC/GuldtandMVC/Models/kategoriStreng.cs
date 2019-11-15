using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC.Models
{
    public class kategoriStreng
    {
        public kategoriStreng()
        {
            varer = new List<Product>();
        }
        public string kategori { get; set; }
        public List<string> kategories { get; set; }
        public List<Product> varer { get; set; }
    }
}

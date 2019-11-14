using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuldtandMVC_Identity.Models
{
    public class KategoriStreng
    {
        public KategoriStreng()
        {
            varer = new List<NyVare>();
        }
        public string kategori { get; set; }
        public List<string> kategories { get; set; }
        public List<NyVare> varer { get; set; }
    }
}

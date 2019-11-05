using System;
using System.Collections.Generic;

namespace tilbud
{
    public partial class OpskriftKategori
    {
        public int OpskriftId { get; set; }
        public string Kategori { get; set; }

        public virtual Kategori KategoriNavigation { get; set; }
        public virtual Opskrift Opskrift { get; set; }
    }
}

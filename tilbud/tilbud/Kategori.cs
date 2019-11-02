using System;
using System.Collections.Generic;

namespace tilbud
{
    public partial class Kategori
    {
        public Kategori()
        {
            OpskriftKategori = new HashSet<OpskriftKategori>();
            VareKategori = new HashSet<VareKategori>();
        }

        public string Kategori1 { get; set; }

        public virtual ICollection<OpskriftKategori> OpskriftKategori { get; set; }
        public virtual ICollection<VareKategori> VareKategori { get; set; }
    }
}

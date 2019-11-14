using System;
using System.Collections.Generic;

namespace GuldtandMVC_Identity.Models
{
    public partial class NyVare
    {
        public NyVare()
        {
            VareKategori = new HashSet<VareKategori>();
        }

        public int VareId { get; set; }
        public string Navn { get; set; }
        public string Butik { get; set; }
        public double? Pris { get; set; }
        public DateTime ValidFra { get; set; }
        public DateTime ValidTil { get; set; }
        public int Volumen { get; set; }
        public double? Volumenpris { get; set; }
        public string ImgSrc { get; set; }

        public virtual ICollection<VareKategori> VareKategori { get; set; }
    }
}

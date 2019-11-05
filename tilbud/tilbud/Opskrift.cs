using System;
using System.Collections.Generic;

namespace tilbud
{
    public partial class Opskrift
    {
        public Opskrift()
        {
            OpskriftKategori = new HashSet<OpskriftKategori>();
        }

        public int OpskriftId { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }
        public double Pris { get; set; }
        public double Besparelse { get; set; }

        public virtual ICollection<OpskriftKategori> OpskriftKategori { get; set; }
    }
}

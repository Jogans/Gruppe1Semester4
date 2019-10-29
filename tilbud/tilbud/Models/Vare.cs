using System;
using System.Collections.Generic;

namespace tilbud
{
    public partial class Vare
    {
        public int VareId { get; set; }
        public string Navn { get; set; }
        public double? Pris { get; set; }
        public string Butik { get; set; }
        public string ValidFra { get; set; }
        public string ValidTil { get; set; }
        public double? Volumenpris { get; set; }
        public double? Volumen { get; set; }
        public string Imgsrc { get; set; }
    }
}

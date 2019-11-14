using System;
using System.Collections.Generic;

namespace GuldtandMVC_Identity.Models
{
    public partial class Butik
    {
        public Butik()
        {
            Abningstid = new HashSet<Abningstid>();
        }

        public int ButikId { get; set; }
        public int VareId { get; set; }
        public string Butiknavn { get; set; }
        public string Addresse { get; set; }

        public virtual Vare Vare { get; set; }
        public virtual ICollection<Abningstid> Abningstid { get; set; }
    }
}

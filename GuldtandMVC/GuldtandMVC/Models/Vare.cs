using System;
using System.Collections.Generic;

namespace GuldtandMVC.Models
{
    public partial class Vare
    {
        public Vare()
        {
            ButikNavigation = new HashSet<Butik>();
        }

        public int VareId { get; set; }
        public string Navn { get; set; }
        public double? Pris { get; set; }
        public string Butik { get; set; }
        public string ValidFra { get; set; }
        public string ValidTil { get; set; }
        public double? Volumenpris { get; set; }
        public double? Volumen { get; set; }
        public string Imgsrc { get; set; }
        public bool UnwantedBool { get; set; }

        public virtual ICollection<Butik> ButikNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GuldtandMVC_Identity.Models
{
    public partial class Abningstid
    {
        public string Ugedag { get; set; }
        public TimeSpan? AbenFra { get; set; }
        public TimeSpan? AbenTil { get; set; }
        public int ButikId { get; set; }

        public virtual Butik Butik { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace GuldtandMVC_Identity.Models
{
    public partial class VareKategori
    {
        public int VareId { get; set; }
        public string Kategori { get; set; }

        public virtual Kategori KategoriNavigation { get; set; }
        public virtual NyVare Vare { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace GuldtandMVC_Identity.Models
{
    public partial class ProductCategory
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }

        public virtual Category CategoryNameNavigation { get; set; }
        public virtual Product Product { get; set; }
    }
}
